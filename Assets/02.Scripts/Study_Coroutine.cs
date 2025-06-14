using UnityEngine;
using System.Collections;

public class Study_Coroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RoutineA());

        Invoke("StopMethod", 3f);
    }

    IEnumerator RoutineA() // 대기를 할 수 있는 기능
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("안녕하세요.");

        yield return new WaitForSeconds(2f);
        Debug.Log("Hello Unity");

        yield return new WaitForSeconds(2f);
        Debug.Log("Coroutine");
    }

    private void StopMethod()
    {
        StopCoroutine(RoutineA());
    }
}
