using UnityEngine;

public class Collider_Events : MonoBehaviour
{
    public GameObject fade;

    //상호작용하는 둘 다 isTrigger = false일 경우 호출
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            fade.SetActive(true);
            Debug.Log("Game Over!!");
        }
            Debug.Log($"Collision Enter : {this.gameObject.name}");
    }

    //상호작용하는 둘 중 하나라도 isTrigger = true일 경우 호출
    //private void OnTriggerEnter(Collider col)
    //{
    //    Debug.Log($"Trigger Enter : {this.gameObject.name}");
    //}
}
