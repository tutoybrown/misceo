using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerishere : MonoBehaviour
{
    public int playerlocationnumber;
    
    public GameObject hud;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InteractSub.playerlocation = playerlocationnumber;
            hud.SetActive(true);
        }

    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InteractSub.playerlocation = 0;
            hud.SetActive(false);
        }

    }
}
