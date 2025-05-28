using UnityEngine;

public class Cat_Controller : MonoBehaviour
{
    public float jumpPower = 10f;
    public bool isGround = false;

    public int jumpCount = 0;

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpCount<2)
        {
            rb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Ground"))
        {
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
