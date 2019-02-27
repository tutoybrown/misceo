using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveCarried : MonoBehaviour
{
    public float speed = 1f;
    public float angle = 90f;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    void FixedUpdate()
    {

        if (Input.GetKeyDown("a"))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown("q"))
        {
            transform.Rotate(angle * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown("e"))
        {
            transform.Rotate(-angle * Time.deltaTime, 0.0f, 0.0f);
        }


        //rb.AddForce(movement * speed);
    }
}
