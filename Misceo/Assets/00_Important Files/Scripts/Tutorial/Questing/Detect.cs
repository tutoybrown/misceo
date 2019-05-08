using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public string detect;
    public int number;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(detect))
        {
            Quest_2.Quest[number] = true;
            Quest_2.Quest[number - 1] = false;
            Quest_2.Unvisited[number - 1] = false;
        }

    }
}
