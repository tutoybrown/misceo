using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            InteractSub.main.enabled = true;
            InteractSub.worktable1.enabled = false;
            
            //InteractSub.Destroy(Interact.interactedObjects);
            //InteractSub.Destroy(carriedObjects);
            InteractSub.player.SetActive(true);
        }
    }
}
