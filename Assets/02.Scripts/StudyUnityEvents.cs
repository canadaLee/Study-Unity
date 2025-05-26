using UnityEngine;

public class StudyUnityEvents : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
        
    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        
    }
}
