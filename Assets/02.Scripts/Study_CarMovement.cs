using UnityEngine;

public class Study_CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;

    private float h;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        //Transform �̵�
        //transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;

    }

    private void FixedUpdate() //���� ���������� ����Ǵ� ����Ƽ �⺻ �Լ�
    {
        //Rigidbody�� �ӵ��� Ȱ���� �̵�
        carRb.linearVelocityX = h * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("BugStone Enter!");
    }
    private void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log("BugStone Stay!");
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log("BugStone Exit!");
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("BugStone Enter!");
    }
    private void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("BugStone Stay!");
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("BugStone Exit!");
    }
}
