using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractSub : MonoBehaviour
{
    public static int playerlocation;

    public static Transform worktable1a, worktable1b, worktable2a, worktable2b, worktable3a, worktable3b, worktable4a, worktable4b, worktable5a, worktable5b, hotplates;

    public static Camera main, worktable1, worktable2, worktable3, worktable4, worktable5, hotplate;

    public Transform worktale1a, worktale1b, worktale2a, worktale2b, worktale3a, worktale3b, worktale4a, worktale4b, worktale5a, worktale5b, hotplatess;

    public static GameObject player;

    public static int pouring;

    public GameObject players;


    // 
    //

    public Camera mains, worktable1s, hotplat;

    public Rigidbody body, body2;
        
        //, worktable2, worktable3, worktable4, worktable5;

    void Start()
    {
        worktable1a = worktale1a;
        worktable1b = worktale1b;
        worktable2a = worktale2a;
        worktable2b = worktale2b;
        worktable3a = worktale3a;
        worktable3b = worktale3b;
        worktable4a = worktale4a;
        worktable4b = worktale4b;
        worktable5a = worktale5a;
        worktable5b = worktale5b;
        hotplate = hotplat;
        hotplates = hotplatess;
        main = mains;
        worktable1 = worktable1s;
        player = players;
        pouring = 0;

    }

   void FixedUpdate()
        {
        //Debug.Log("Lol");

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
        }
    }
