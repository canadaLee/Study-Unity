using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    SpriteRenderer spriteRenderer;

    public Vector3 returnPos;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        ////����� �������� �̵��ϴ� ���
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -returnPos.x *1.5f)
        {
            transform.position = returnPos;
        }

        //if (transform.position.x <= -spriteRenderer.size.x)
        //{
        //    transform.Translate((spriteRenderer.size.x * 2) * Vector3.right);
        //}
    }
}
