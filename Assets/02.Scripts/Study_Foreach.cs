using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] { "ö��","����","����", "����Ŭ", "��"};

    public string findName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindPerson(findName);
    }

    public void FindPerson(string name)
    {
        foreach (string person in persons)
        {
            if(person ==name)
            {
                Debug.Log($"�ο� �߿� {name}�� �����մϴ�");
            }
        }
    }

}
