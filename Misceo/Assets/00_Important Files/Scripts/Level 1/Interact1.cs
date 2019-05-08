using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact1
{
    public ObjectMoveCarried carriedObjects;
    public ObjectMove interactedObjects;

    void Start()
    {
        InteractSub1.main.enabled = true;
        InteractSub1.worktable1.enabled = false;
        InteractSub1.hotplatecams.enabled = false;

    }

    public void interactGlassware(GameObject carriedObject, GameObject interactedObject)
    {
        if (InteractSub1.playerlocation == 1)
        {
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            carriedObject.transform.SetParent(InteractSub1.worktable1a);
            interactedObject.transform.SetParent(InteractSub1.worktable1b);

            carriedObject.transform.localPosition = new Vector3(0, 0, 0);
            interactedObject.transform.localPosition = new Vector3(0, 0, 0);

            Vector3 newRotation = new Vector3(InteractSub1.worktable1a.transform.eulerAngles.x, InteractSub1.worktable1a.transform.eulerAngles.y, InteractSub1.worktable1a.transform.eulerAngles.z);
            carriedObject.transform.eulerAngles = newRotation;

            Vector3 newRotationb = new Vector3(InteractSub1.worktable1b.transform.eulerAngles.x, InteractSub1.worktable1b.transform.eulerAngles.y, InteractSub1.worktable1b.transform.eulerAngles.z);
            interactedObject.transform.eulerAngles = newRotationb;
            //move the things
            carriedObject.AddComponent<ObjectMoveCarried>().enabled = true;
            interactedObject.AddComponent<ObjectMove>().enabled = true;

            InteractSub1.pouring = true;
            InteractSub1.observe = true;

            InteractSub1.worktable1a.DetachChildren();
            InteractSub1.worktable1b.DetachChildren();

            InteractSub1.worktable1.enabled = true;
            InteractSub1.main.enabled = false;
            InteractSub1.player.SetActive(false);
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

            InteractSub1.equipment = true;

            InteractSub1.hotplate.DetachChildren();

            InteractSub1.hotplatecams.enabled = true;
            InteractSub1.main.enabled = false;
            InteractSub1.player.SetActive(false);

           
        }
        
    }
    public void interactComputer()
    {
        Debug.Log("You interacted with a Computer");
    }

}
 