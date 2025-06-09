using UnityEngine;

public class Study_For : MonoBehaviour
{
    public int[] arrayInt = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < arrayInt.Length; i++)
        {
            Debug.Log($"i : {arrayInt[i]}");
        }
    }
  
}
