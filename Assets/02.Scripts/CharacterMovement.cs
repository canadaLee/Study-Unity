using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public SpriteRenderer[] renderers;

    private float h;
    private float jumpPower = 3f;
    private Rigidbody2D rb;

    private bool isGround = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");


        Jump();
    }

    private void FixedUpdate()
    {
        Move();
       
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isGround = true;

        renderers[2].gameObject.SetActive(false);
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        isGround = false;

        renderers[0].gameObject.SetActive(false); // Idle
        renderers[1].gameObject.SetActive(false); // Run
        renderers[2].gameObject.SetActive(true); // Jump
    }


    public void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForceY(jumpPower, ForceMode2D.Impulse);
        }
    }
    public void Move()
    {
        //if (h != 0)
        //{
        //    //�������� �̵� linearVelocity == ������ �����̵Ǹ� 0 �� �ǹǷ� ��¦ ������ ���� ������ �ش�.

        //    if (isGround)
        //    {
        //        renderers[0].gameObject.SetActive(false);
        //        renderers[1].gameObject.SetActive(true);

        //        rb.linearVelocityX = h * moveSpeed;

        //    }
        //    else
        //    {
        //        renderers[0].gameObject.SetActive(false);
        //        renderers[1].gameObject.SetActive(false);
        //    }
        //    Filp();
        //}      
        //else
        //{
        //    renderers[0].gameObject.SetActive(true);
        //    renderers[1].gameObject.SetActive(false);
        //}


        if (h != 0) // �Է� Ű�� ���� ��
        {
            if (isGround)
            {
                renderers[0].gameObject.SetActive(false); // Idle
                renderers[1].gameObject.SetActive(true); // Run
            }
            else
            {
                renderers[0].gameObject.SetActive(false); // Idle
                renderers[1].gameObject.SetActive(false); // Run
            }

            rb.linearVelocityX = h * moveSpeed; // �������� �̵�

            Filp();
        }
        else if (h == 0)// �Է� Ű�� ������ ���� ��
        {
            if (isGround)
            {
                renderers[0].gameObject.SetActive(true); // Idle
                renderers[1].gameObject.SetActive(false); // Run
            }
            else
            {
                renderers[0].gameObject.SetActive(false); // Idle
                renderers[1].gameObject.SetActive(false); // Run
            }
        }
    }

    public void Filp()
    {
        if (h > 0)
        {
            renderers[0].flipX = false;
            renderers[1].flipX = false;
            renderers[2].flipX = false;
        }
        else if (h < 0)
        {
            renderers[0].flipX = true;
            renderers[1].flipX = true;
            renderers[2].flipX = true;
        }
    }
}
