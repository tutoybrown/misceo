using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    float speed = 10.0f;

    /*
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }

    }
    */

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; 
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint) ; 
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

}
