using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact
{
    public ObjectMoveCarried carriedObjects;
    public ObjectMove interactedObjects;

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
            //move the things
            carriedObject.AddComponent<ObjectMoveCarried>().enabled = true;
            interactedObject.AddComponent<ObjectMove>().enabled = true;

            InteractSub.pouring = 1;

            InteractSub.worktable1a.DetachChildren();
            InteractSub.worktable1b.DetachChildren();

            InteractSub.worktable1.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);
        }
        //Debug.Log("You interacted with a Glassware");
    }

   

    public void interactLabEquipment(GameObject carriedObject, GameObject interactedObject)
    {
        Hotplate i = interactedObject.GetComponent<Hotplate>();
        if (i != null)
        {
            carriedObject.transform.SetParent(InteractSub.worktable1a);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            
            

            InteractSub.pouring = 1;

            InteractSub.worktable1a.DetachChildren();
            InteractSub.worktable1b.DetachChildren();

            InteractSub.worktable1.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);



        }
        Debug.Log("You interacted with a Lab Equipment");
    }
    public void interactComputer()
    {
        Debug.Log("You interacted with a Computer");
    }

}
 