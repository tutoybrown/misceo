using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerishere : MonoBehaviour
{
    public int playerlocationnumber;
    public bool inside = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InteractSub.playerlocation = playerlocationnumber;
            inside = true;
        }

    }
    void OnGUI()
    {
        if (inside)
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height - 150, 150, 30), "You are now in Workstation: " + playerlocationnumber);
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
