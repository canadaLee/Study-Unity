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

        //Debug.Log($"이름 : {obj.name}"); // 게임오브젝트의 이름
        //Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
        //Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        //Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        //Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기

        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>()}");
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
