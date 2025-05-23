using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += Vector3.forward * Time.deltaTime * moveSpeed;

        //if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        //{
        //    transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        //{
        //    transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        //{
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}

        //if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        //{
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}


        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized;

      //  Debug.Log($"현재 입력 : {normalDir}");

        this.transform.position += normalDir * Time.deltaTime * moveSpeed;

        transform.LookAt(transform.position + normalDir);

    }
}
