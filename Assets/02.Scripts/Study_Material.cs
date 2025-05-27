using UnityEngine;

public class Study_Material : MonoBehaviour
{
    public Material mat;
    

    void Start()
    {
        this.GetComponent<MeshRenderer>().material = mat;
        
    }

  
}
