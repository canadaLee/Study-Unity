using System.Collections;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 5f;

    public bool isStop = false;

    private void Start()
    {
        rotSpeed = 0f;
    }

    void Update()
    {

        transform.Rotate(Vector3.forward * rotSpeed);
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if(isStop)
        {
            rotSpeed *= 0.98f;

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0;
                isStop = false;
            }
        }
        //Debug.Log($"rotSpeed : {rotSpeed}");
    }
}
