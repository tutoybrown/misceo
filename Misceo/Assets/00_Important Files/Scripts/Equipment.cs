using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    /*
    public float speed = 1f;
    public float angle = 90f;
    public float maxrotation = 60f;
    */

    //Vector3 rotlimit;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        rb.useGravity = true;

        rb.isKinematic = false;
        //transform.eulerAngles = new Vector3(Mathf.Clamp(transform.eulerAngles.x, -maxrotation, maxrotation), 0, 0);
        //rotlimit = new Vector3(Mathf.Clamp(transform.eulerAngles.x, -maxrotation, maxrotation), 0, 0);
    }
}
