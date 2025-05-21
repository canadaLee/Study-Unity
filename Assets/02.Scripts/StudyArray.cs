using UnityEngine;
using System.Collections.Generic;

public class StudyArray : MonoBehaviour
{
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };
    
    public List<int> listNumber = new List<int>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");


        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        Debug.Log($"List에 있는 데이터 수 : {listNumber.Count}");
    }
}
