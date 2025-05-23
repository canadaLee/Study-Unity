using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;

    private void Start()
    {
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;

        
    }
}
