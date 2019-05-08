using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementQ : MonoBehaviour
{
    public bool w, a, s, d = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") )
        {
            w = true;
        }

        if (Input.GetKeyDown("s"))
        {
            s = true;
        }

        if (Input.GetKeyDown("d"))
        {
            d = true;
        }

        if (Input.GetKeyDown("a"))
        {
            a = true;
        }

        if (w && s && d && a)
        {
            //Questing.Movement = true;
        }
    }
}
