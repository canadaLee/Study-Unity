using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject obj;

    public string obj_name;

    public Mesh msh;
    public Material mat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //obj = GameObject.FindGameObjectWithTag("Player");

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //Debug.Log($"�̸� : {obj.name}"); // ���ӿ�����Ʈ�� �̸�
        //Debug.Log($"�±� : {obj.tag}"); // ���ӿ�����Ʈ�� �±�
        //Debug.Log($"��ġ : {obj.transform.position}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        //Debug.Log($"ȸ�� : {obj.transform.rotation}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        //Debug.Log($"ũ�� : {obj.transform.localScale}"); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

        //Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>()}");
        CreateCube();
    }

    public void CreateCube()
    {
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
