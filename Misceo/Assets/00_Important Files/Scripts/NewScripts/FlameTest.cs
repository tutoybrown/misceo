using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameTest : MonoBehaviour
{
    public bool one, two, three, four;
    public GameObject finished;
    public void One()
    {
        one = true;
    }
    public void Two()
    {
        two = true;
    }
    public void Three()
    {
       three = true;
    }
    public void Four()
    {
        four = true;
    }
    public void Check()
    {
        if (one == true && two == true && three == true && four == true)
        {
            finished.SetActive(true);
        }
    }
}
