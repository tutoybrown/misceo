using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerishere1 : MonoBehaviour
{
    public int playerlocationnumber;
    
    public GameObject hud;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InteractSub1.playerlocation = playerlocationnumber;
            hud.SetActive(true);
        }

    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InteractSub1.playerlocation = 0;
            hud.SetActive(false);
        }

    }
}
