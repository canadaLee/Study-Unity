using UnityEngine;

public class Study_Something : MonoBehaviour
{
    public int currentLevel = 10;

    public int maxLevel = 99;
    
    void Start()
    {
        //�� ���꿡 ���� ����� bool ������ �޴� �ڵ�
        bool isMax = currentLevel >= maxLevel;
        Debug.Log($"���� ������ ������{isMax}�Դϴ�.");

        string msg = currentLevel >= maxLevel ? "���� �����Դϴ�." : "���� ������ �ƴմϴ�.";
        Debug.Log(msg);
    
        
    }


}
