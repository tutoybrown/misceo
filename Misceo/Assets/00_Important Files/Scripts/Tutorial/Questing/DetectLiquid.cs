using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLiquid : MonoBehaviour
{
    public string detect, liquid;
    public int number;

   
    

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(detect))
        {
            Liquid script = other.GetComponent<Liquid>();
            if (script.liquid == liquid)
            {
                Quest_2.Quest[number] = true;
                Quest_2.Quest[number - 1] = false;
                Quest_2.Unvisited[number - 1] = false;
            }
            
        }

    }
}
