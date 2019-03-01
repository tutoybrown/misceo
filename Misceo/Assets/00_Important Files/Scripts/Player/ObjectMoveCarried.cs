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

    void Update()
    {

        if (Input.GetKey("a"))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        //ROTATE (put Mathf.Clamp)
        if (Input.GetKey("q"))
        {
            transform.Rotate(angle * Time.deltaTime, 0.0f, 0.0f);
            //rotationX = Mathf.Clamp(rotationX, -maxCameraRotation, maxCameraRotation);
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(-angle * Time.deltaTime, 0.0f, 0.0f);

        }


        //rb.AddForce(movement * speed);
    }
}
