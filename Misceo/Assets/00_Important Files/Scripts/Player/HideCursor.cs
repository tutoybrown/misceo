﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour
{
    void Start()
    {
       // Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
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
