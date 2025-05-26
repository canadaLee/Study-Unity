using UnityEngine;

public class Study_Transfrom : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //월드 방향으로 이동하는 기능
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //로컬 방향으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //월드 방향으로 회전
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime,Space.World);

        //로컬 방향으로 회전
        //transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.eulerAngles.z);
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        //특정 위치의 주변을 회전
        //transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        //특정 위치를 바라보며 회전(?) 회전은 안함 잘못적으신듯
        transform.LookAt(Vector3.zero);
    
    }
}
