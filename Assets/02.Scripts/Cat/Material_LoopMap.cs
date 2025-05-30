using UnityEngine;

public class Material_LoopMap : MonoBehaviour
{
    private new MeshRenderer renderer;

    public float offsetSpeed = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = Vector2.right * offsetSpeed * Time.deltaTime;
        renderer.material.SetTextureOffset("_MainTex", renderer.material.mainTextureOffset + offset);
    }
}
