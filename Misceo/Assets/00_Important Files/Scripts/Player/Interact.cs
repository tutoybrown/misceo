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
        Debug.Log("lol");
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

        /*
        if (InteractSub.playerlocation == 3)
        {
            carriedObject.transform.SetParent(InteractSub.worktable3a);
            interactedObject.transform.SetParent(InteractSub.worktable3b);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            interactedObject.transform.localPosition = new Vector3(0, 0, 0);
            //move the things
            carriedObject.AddComponent<ObjectMoveCarried>().enabled = true;
            interactedObject.AddComponent<ObjectMove>().enabled = true;

            InteractSub.pouring = 1;

            InteractSub.worktable1a.DetachChildren();
            InteractSub.worktable1b.DetachChildren();

            InteractSub.worktable3.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);
        }

        if (InteractSub.playerlocation == 4)
        {
            carriedObject.transform.SetParent(InteractSub.worktable4a);
            interactedObject.transform.SetParent(InteractSub.worktable4b);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            interactedObject.transform.localPosition = new Vector3(0, 0, 0);
            //move the things
            carriedObject.AddComponent<ObjectMoveCarried>().enabled = true;
            interactedObject.AddComponent<ObjectMove>().enabled = true;

            InteractSub.pouring = 1;

            InteractSub.worktable4a.DetachChildren();
            InteractSub.worktable4b.DetachChildren();

            InteractSub.worktable1.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);
        }

        if (InteractSub.playerlocation == 5)
        {
            carriedObject.transform.SetParent(InteractSub.worktable5a);
            interactedObject.transform.SetParent(InteractSub.worktable5b);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            interactedObject.transform.localPosition = new Vector3(0, 0, 0);
            //move the things
            carriedObject.AddComponent<ObjectMoveCarried>().enabled = true;
            interactedObject.AddComponent<ObjectMove>().enabled = true;

            InteractSub.pouring = 1;

            InteractSub.worktable1a.DetachChildren();
            InteractSub.worktable1b.DetachChildren();

            InteractSub.worktable5.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);
        }
        */
        //Debug.Log("You interacted with a Glassware");
    }

   

    public void interactLabEquipment(GameObject carriedObject, GameObject interactedObject)
    {
        Hotplate i = interactedObject.GetComponent<Hotplate>();
        if (i != null)
        {
            carriedObject.transform.SetParent(InteractSub.hotplates);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            

            InteractSub.hotplates.DetachChildren();
            InteractSub.hotplate.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);

                

        }
        Debug.Log("You interacted with a Lab Equipment");
    }
    /*
    public void interactComputer()
    {
        Debug.Log("You interacted with a Computer");
    }
    */
}
 