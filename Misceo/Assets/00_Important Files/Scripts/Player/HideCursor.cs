using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    void Start()
    {
       // Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Confined;
    }
}
