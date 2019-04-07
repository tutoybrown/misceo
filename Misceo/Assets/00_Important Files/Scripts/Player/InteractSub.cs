using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractSub : MonoBehaviour
{
    public static int playerlocation;

    public static Transform worktable1a, worktable1b, hotplate;

    //worktable2a, worktable2b, worktable3a, worktable3b, worktable4a, worktable4b, worktable5a, worktable5b, 

    public static Camera main, worktable1, hotplatecams;

    // worktable2, worktable3, worktable4, worktable5,

    public Transform worktale1a, worktale1b, hotplates;

    public static GameObject player;

    public static int pouring, equipment;

    public GameObject players;


    // worktale2a, worktale2b, worktale3a, worktale3b
    //, worktable4a, worktable4b, worktable5a, worktable5b

    public Camera mains, worktable1s, hotplatecam;

    public Rigidbody body, body2;
        
        //, worktable2, worktable3, worktable4, worktable5;

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
        pouring = 0;
        equipment = 0;
    }

    
   void FixedUpdate()
        {
        // FOR EXITING THE POURING MODE
            if (Input.GetKeyDown("f") && pouring == 1)
            {
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

                InteractSub.pouring = 0;
            }

            if (Input.GetKeyDown("f") && equipment == 1)
            {
                Equipment equip = PickupObject.carriedObject.GetComponent<Equipment>();


                InteractSub.main.enabled = true;
                InteractSub.hotplatecams.enabled = false;
                
                body = PickupObject.carriedObject.GetComponent<Rigidbody>();
                
                body.isKinematic = false;
                body.useGravity = true;


                Destroy(equip);
                InteractSub.player.SetActive(true);

                InteractSub.equipment = 0;
            }
        }
    }
