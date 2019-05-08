using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect1 : MonoBehaviour
{
    public string detect;
    public int number;
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(detect))
        {
            Quest_21.Quest[number] = true;
            Quest_21.Quest[number - 1] = false;
            Quest_21.Unvisited[number - 1] = false;
        }

    }
}
