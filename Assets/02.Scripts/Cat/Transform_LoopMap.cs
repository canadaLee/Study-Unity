using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        ////배경을 왼쪽으로 이동하는 기능
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    
        if (transform.position.x <= -spriteRenderer.size.x)
        {
            transform.Translate((spriteRenderer.size.x * 2) * Vector3.right);
        }
    }
}
