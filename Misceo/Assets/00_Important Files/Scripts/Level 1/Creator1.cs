using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator1 : MonoBehaviour
{
    public GameObject erlenmeyerwater,erlemeyerempty,beakerwater,beakerempty;

    public Vector3 erlen, beak;
    public static bool erlenmeyer, beaker;
    public static bool empty, water; // pota lead

    public void Erlen()
    {
        erlenmeyer = true;
    }

    public void Beak()
    {
        beaker = true;
    }

    public void Water()
    {
        water = true;
    }

    public void Empty()
    {
        empty = true;
    }

    public void Restart()
    {
        erlenmeyer = false;
        beaker = false;
        empty = false;
        water = false;
    }

    public void Create()
    {
        if (erlenmeyer && water)
        {
            Instantiate(erlenmeyerwater, erlen, Quaternion.identity);
            
        }

        if (erlenmeyer && empty)
        {
            Instantiate(erlenmeyerwater, erlen, Quaternion.identity);
        }

        if (beaker && empty)
        {
            Instantiate(beakerempty, beak, Quaternion.identity);
            Quest_21.Quest[1] = true;
            Quest_21.Quest[0] = false;
            Quest_2.Unvisited[0] = false;
        }

        if (beaker && water)
        {
            Instantiate(beakerwater, beak, Quaternion.identity);
            Quest_21.Quest[2] = true;
            Quest_21.Quest[1] = false;
            Quest_21.Unvisited[1] = false;
        }
    }
}
