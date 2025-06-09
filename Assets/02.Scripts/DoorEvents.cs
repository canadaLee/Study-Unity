using UnityEngine;

public class DoorEvents : MonoBehaviour
{
    public GameObject doorLock;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            doorLock.SetActive(true);
            //anim.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            doorLock.SetActive(false);
            //anim.SetTrigger("Close");
        }
    }
}
