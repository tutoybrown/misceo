using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class InteractSub1 : MonoBehaviour
{
    public static int playerlocation;

    public static Transform worktable1a, worktable1b, hotplate;

    

    public static Camera main, worktable1, hotplatecams;

   

    public Transform worktale1a, worktale1b, hotplates;

    public static GameObject player;

    public static bool pouring, equipment, observe;

    public GameObject players;

    public GameObject outpour, outhot, outobserve;


 

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
        observe = false;
    }

    void Update()
    {
        if (equipment)
        {
            outhot.SetActive(true);
        }

        if (pouring)
        {
            outpour.SetActive(true);
        }

        if (observe)
        {
            outobserve.SetActive(true);
        }

    }

    public void OutPouring()
    {
        // FOR EXITING THE POURING MODE
            ObjectMoveCarried carriedObjects = PickupObject.carriedObject.GetComponent<ObjectMoveCarried>();
            ObjectMove interactedObjects = PickupObject.interactedObject.GetComponent<ObjectMove>();

            main.enabled = true;
            worktable1.enabled = false;

            body = PickupObject.carriedObject.GetComponent<Rigidbody>();
            body2 = PickupObject.interactedObject.GetComponent<Rigidbody>();
            body.isKinematic = false;
            body.useGravity = true;
            body2.isKinematic = false;
            body2.useGravity = true;

            Destroy(interactedObjects);
            Destroy(carriedObjects);
            player.SetActive(true);

            pouring = false;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

    }

    public void OutHotplate()
    {
            
                Equipment equip = PickupObject.carriedObject.GetComponent<Equipment>();

                main.enabled = true;
                hotplatecams.enabled = false;
                
                body = PickupObject.carriedObject.GetComponent<Rigidbody>();
                
                body.isKinematic = false;
                body.useGravity = true;


                Destroy(equip);
                player.SetActive(true);

                equipment = false;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
    }
}

