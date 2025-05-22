using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject destroyObj;
    public Vector3 pos;
    public Quaternion rot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateAmongUs();
        //Destroy(destroyObj, 3f);
    }

    public void CreateAmongUs()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "어몽어스 캐릭터";

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {obj.transform.GetChild(obj.transform.childCount-1).name}");
    }
}
