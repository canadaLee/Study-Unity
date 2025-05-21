using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject cube;

    public string obj_name;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube.name = obj_name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
