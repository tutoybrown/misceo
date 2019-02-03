using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    GameObject mainCamera;
    bool carrying;
    GameObject carriedObject;
    public float distance;
    public float smooth;
    GameObject interactedObject;
    string debug;

    int x = Screen.width / 2;
    int y = Screen.height / 2;

    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (carrying)
        {
            carry(carriedObject);
            checkInteractable();
            checkDrop();
        }
        else
        {
            pickup();
        }
    }

    void carry(GameObject o)
    {
        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
        o.transform.rotation = Quaternion.identity;
    }

    void pickup()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Pickupable p = hit.collider.GetComponent<Pickupable>();
                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    //p.gameObject.rigidbody.isKinematic = true;
                    p.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    //IGNORE RAYCAST TEMPORARILY
                    carriedObject.layer = LayerMask.NameToLayer("Ignore Raycast");
                }
            }
        }
    }

    void checkDrop()
    {
        if (Input.GetMouseButtonDown(1))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject.layer = LayerMask.NameToLayer("Default");
        carriedObject = null;
    }

    void checkInteractable()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            interact();
        }
    }

    void interact()
    {
        Ray rayinteract = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
        RaycastHit hit2;
        if (Physics.Raycast(rayinteract, out hit2))
        {
            Interactable i = hit2.collider.GetComponent<Interactable>();
            if (i != null)
            {
                interactedObject = i.gameObject;
                debug=hit2.collider.name;
                Debug.Log(debug);
                
            }
        }
    }
}