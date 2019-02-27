using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera Main, UI;
    public GameObject next, crosshair;

    
    void Start()
    {
        Main.enabled = true;
        UI.enabled = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e") && other.tag == "MainCamera")
        {
            next.SetActive(true);
            crosshair.SetActive(false);
            Main.enabled = !UI.enabled;
            UI.enabled = !Main.enabled;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}