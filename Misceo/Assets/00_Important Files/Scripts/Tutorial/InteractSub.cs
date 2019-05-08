using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractSub : MonoBehaviour
{
    public static int playerlocation;

    public static Transform worktable1a, worktable1b, hotplate;

    

    public static Camera main, worktable1, hotplatecams;

   

    public Transform worktale1a, worktale1b, hotplates;

    public static GameObject player;

    public static bool pouring, equipment;

    public GameObject players;

    public GameObject outpour, outhot;


 

    public Camera mains, worktable1s, hotplatecam;

    public Rigidbody body, body2;
        
        

    void Start()
    {
        //Locations
        worktable1a = worktale1a;
        worktable1b = worktale1b;
        hotplate = hotplates;

        //Camera
        main = mains;
        worktable1 = worktable1s;
        hotplatecams = hotplatecam;

        //Player
        player = players;

        //Modes
        pouring = false;
        equipment = false;
    }

    void Update()
    {
        if (equipment)
        {
            outhot.SetActive(true);
            Quest_2.Quest[6] = true;
            Quest_2.Quest[6 - 1] = false;
            Quest_2.Unvisited[6 - 1] = false;
        }

        if (pouring)
        {
            outpour.SetActive(true);
            Quest_2.Quest[5] = true;
            Quest_2.Quest[5 - 1] = false;
            Quest_2.Unvisited[5 - 1] = false;
        }

    }

    public void OutPouring()
    {
        // FOR EXITING THE POURING MODE
            ObjectMoveCarried carriedObjects = PickupObject.carriedObject.GetComponent<ObjectMoveCarried>();
            ObjectMove interactedObjects = PickupObject.interactedObject.GetComponent<ObjectMove>();

            InteractSub.main.enabled = true;
            InteractSub.worktable1.enabled = false;

            body = PickupObject.carriedObject.GetComponent<Rigidbody>();
            body2 = PickupObject.interactedObject.GetComponent<Rigidbody>();
            body.isKinematic = false;
            body.useGravity = true;
            body2.isKinematic = false;
            body2.useGravity = true;

            Destroy(interactedObjects);
            Destroy(carriedObjects);
            InteractSub.player.SetActive(true);

            InteractSub.pouring = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

    }

    public void OutHotplate()
    {
            
                Equipment equip = PickupObject.carriedObject.GetComponent<Equipment>();

                InteractSub.main.enabled = true;
                InteractSub.hotplatecams.enabled = false;
                
                body = PickupObject.carriedObject.GetComponent<Rigidbody>();
                
                body.isKinematic = false;
                body.useGravity = true;


                Destroy(equip);
                InteractSub.player.SetActive(true);

                InteractSub.equipment = false;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
    }
}

