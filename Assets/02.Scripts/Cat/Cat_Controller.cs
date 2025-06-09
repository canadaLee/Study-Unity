using UnityEngine;
using Cat;
public class Cat_Controller : MonoBehaviour
{
    public SoundManager soundManager;

    public float jumpPower = 10f;
    public bool isGround = false;

    public int jumpCount = 0;

    private Rigidbody2D rb;
    private Animator anim;
    private float limitPower = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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

            if (rb.linearVelocityY > limitPower) // �ڿ������� ������ ���� �ӵ� ����
                rb.linearVelocityY = limitPower;

        }
        var catRotation = transform.eulerAngles;
        catRotation.z = rb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("IsGround",true);
            jumpCount = 0;
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
            isGround = false;
    }
}
