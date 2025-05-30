using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            Debug.Log("Coin get ddo!");
        }
    }
}
