using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTrue : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetTrue()
    {
        Quest_21.Quest[4] = true;
        Quest_21.Quest[3] = false;
        Quest_21.Unvisited[3] = false;
    }

    
}
