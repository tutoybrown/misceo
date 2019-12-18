using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {

       // Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Confined;
    } 

    /*
    public void Cursors()
    {
        // Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    */
}
