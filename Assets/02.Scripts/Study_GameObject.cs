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
        obj.name = "���� ĳ����";

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {obj.transform.childCount}");

        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(obj.transform.childCount-1).name}");
    }
}
