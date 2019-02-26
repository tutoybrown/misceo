using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact
{
   
    void Start()
    {
        InteractSub.main.enabled = true;
        InteractSub.worktable1.enabled = false;
    }

    public void interactGlassware(GameObject carriedObject, GameObject interactedObject)
    {
        if (InteractSub.playerlocation == 1)
        {
            carriedObject.transform.SetParent(InteractSub.worktable1a);
            interactedObject.transform.SetParent(InteractSub.worktable1b);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            interactedObject.transform.localPosition = new Vector3(0, 0, 0);

            InteractSub.main.enabled = !InteractSub.worktable1.enabled;
            InteractSub.worktable1.enabled = !InteractSub.main.enabled;


        }

        //Debug.Log("You interacted with a Glassware");

    }

    public void interactLabEquipment()
    {
        Debug.Log("You interacted with a Lab Equipment");
    }
    public void interactComputer()
    {
        Debug.Log("You interacted with a Computer");
    }

}
 