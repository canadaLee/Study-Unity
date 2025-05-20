using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1;
    public int number2;


    private void Start()
    {
        AddMethod();
        MinusMethod();
    }

    public int AddMethod()
    {
        int result = number1 + number2;
        Debug.Log("Add : " +  result);
        return result;
    }

    public int MinusMethod()
    {
        int result = number1 - number2;
        Debug.Log("Minus : " + result);
        return result;
    }
}
