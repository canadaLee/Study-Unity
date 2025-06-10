using UnityEngine;
using Cat;
public class Cat_Controller : MonoBehaviour
{
    public SoundManager soundManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    public GameObject happy_video;
    public GameObject sad_video;

    public float jumpPower = 10f;

    public int jumpCount = 0;

    private Rigidbody2D rb;
    private Animator anim;
    private float limitPower = 20f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount<2)
        {
            anim.SetTrigger("Jump");
            anim.SetBool("IsGround", false);
            
            rb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;

            soundManager.OnJumpSound();

            if (rb.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
                rb.linearVelocityY = limitPower;

        }
        var catRotation = transform.eulerAngles;
        catRotation.z = rb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cherrie"))
        {
            col.gameObject.SetActive(false);
            col.transform.parent.GetComponent<Item_Events>().particle.SetActive(true);
            GameManager.score += 1;

            if(GameManager.score ==10)
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(1f, Color.white);

                Invoke("HappVideo", 3f);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Pipe"))
        {
            soundManager.OnColliderSound();

            gameOverUI.SetActive(true);
            fadeUI.SetActive(true);
            fadeUI.GetComponent<FadeRoutine>().OnFade(1f, Color.black);

            Invoke("SadVideo", 3f);
        }

        if (col.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("IsGround",true);
            jumpCount = 0;
        }
    }

    public void HappyVideo()
    {
        happy_video.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
    public void SadVideo()
    {
        sad_video.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
}
