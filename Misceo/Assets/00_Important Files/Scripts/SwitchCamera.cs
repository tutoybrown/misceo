using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public Camera Main, UI;
    public GameObject next, crosshair;
    public bool inside = false;

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

            Questing.PressE = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inside = true;
        }

    }
    void OnGUI()
    {
        if (inside)
        {
            GUI.Label(new Rect(Screen.width / 2 + 25, Screen.height - 50, 175, 45), "Press E to use the Computer");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InteractSub.playerlocation = 0;
            inside = false;
        }

    }
}