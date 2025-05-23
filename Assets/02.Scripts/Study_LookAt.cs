using UnityEngine;

public class Study_LookAt : MonoBehaviour
{
    public Transform target_pos;
    public Transform turret_head;

    public GameObject bullet;
    public Transform bullet_pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target_pos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        turret_head.LookAt(target_pos);

        if(Input.GetKeyDown(KeyCode.Space))
            Instantiate(bullet, bullet_pos.position, bullet_pos.rotation);
    }
}
