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
        //���� �������� �̵��ϴ� ���
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        //���� �������� �̵��ϴ� ���
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        //���� �������� ȸ��
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.rotation.eulerAngles.z);
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime,Space.World);

        //���� �������� ȸ��
        //transform.localRotation = Quaternion.Euler(transform.eulerAngles.x, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, transform.eulerAngles.z);
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        //Ư�� ��ġ�� �ֺ��� ȸ��
        //transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        //Ư�� ��ġ�� �ٶ󺸸� ȸ��(?) ȸ���� ���� �߸������ŵ�
        transform.LookAt(Vector3.zero);
    
    }
}
