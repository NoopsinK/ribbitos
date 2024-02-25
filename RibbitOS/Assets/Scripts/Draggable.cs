using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePosition;

    private Vector3 GetMousePos() 
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown() 
    {
        mousePosition = Input.mousePosition - GetMousePos();
        //Debug.Log("Mouse Down");
    }

    public void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
        //Debug.Log("Dragged");
    }
}
