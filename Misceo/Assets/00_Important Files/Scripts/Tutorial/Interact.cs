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
        InteractSub.hotplatecams.enabled = false;

    }

    public void interactGlassware(GameObject carriedObject, GameObject interactedObject)
    {
        if (InteractSub.playerlocation == 1)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            carriedObject.transform.SetParent(InteractSub.worktable1a);
            interactedObject.transform.SetParent(InteractSub.worktable1b);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            interactedObject.transform.localPosition = new Vector3(0, 0, 0);

            Vector3 newRotation = new Vector3(InteractSub.worktable1a.transform.eulerAngles.x, InteractSub.worktable1a.transform.eulerAngles.y, InteractSub.worktable1a.transform.eulerAngles.z);
            carriedObject.transform.eulerAngles = newRotation;

            Vector3 newRotationb = new Vector3(InteractSub.worktable1b.transform.eulerAngles.x, InteractSub.worktable1b.transform.eulerAngles.y, InteractSub.worktable1b.transform.eulerAngles.z);
            interactedObject.transform.eulerAngles = newRotationb;
            //move the things
            carriedObject.AddComponent<ObjectMoveCarried>().enabled = true;
            interactedObject.AddComponent<ObjectMove>().enabled = true;

            InteractSub.pouring = true;

            InteractSub.worktable1a.DetachChildren();
            InteractSub.worktable1b.DetachChildren();

            InteractSub.worktable1.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);
        }
        
    }

   

    public void interactLabEquipment(GameObject carriedObject, GameObject interactedObject)
    {
        Hotplate i = interactedObject.GetComponent<Hotplate>();
        if (i != null)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            carriedObject.transform.SetParent(InteractSub.hotplate);
            
            carriedObject.transform.localPosition = new Vector3(0, 0, 0);

            carriedObject.AddComponent<Equipment>().enabled = true;

            InteractSub.equipment = true;

            InteractSub.hotplate.DetachChildren();

            InteractSub.hotplatecams.enabled = true;
            InteractSub.main.enabled = false;
            InteractSub.player.SetActive(false);

           
        }
        
    }
    public void interactComputer()
    {
        Debug.Log("You interacted with a Computer");
    }

}
 