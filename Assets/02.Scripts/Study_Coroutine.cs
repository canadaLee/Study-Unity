using UnityEngine;
using System.Collections;

public class Study_Coroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RoutineA());

        Invoke("StopMethod", 3f);
    }

    IEnumerator RoutineA() // ��⸦ �� �� �ִ� ���
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("�ȳ��ϼ���.");

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
