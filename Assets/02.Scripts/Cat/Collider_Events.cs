using UnityEngine;

public class Collider_Events : MonoBehaviour
{
    public GameObject fade;

    //��ȣ�ۿ��ϴ� �� �� isTrigger = false�� ��� ȣ��
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            fade.SetActive(true);
            Debug.Log("Game Over!!");
        }
            Debug.Log($"Collision Enter : {this.gameObject.name}");
    }

    //��ȣ�ۿ��ϴ� �� �� �ϳ��� isTrigger = true�� ��� ȣ��
    //private void OnTriggerEnter(Collider col)
    //{
    //    Debug.Log($"Trigger Enter : {this.gameObject.name}");
    //}
}
