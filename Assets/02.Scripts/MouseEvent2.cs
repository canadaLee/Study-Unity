using UnityEngine;

public class MouseEvent2 : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter : 1");
    }
    private void OnMouseOver()
    {
        Debug.Log("Mouse Over : 2");
    }
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down : 3");
    }
    private void OnMouseDrag()
    {
        Debug.Log("Mouse Drag : 4");
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("Mouse UpAs");

    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }


}
