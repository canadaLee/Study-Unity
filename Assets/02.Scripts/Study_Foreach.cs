using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] { "철수","영희","동수", "마이클", "존"};

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
                Debug.Log($"인원 중에 {name}이 존재합니다");
            }
        }
    }

}
