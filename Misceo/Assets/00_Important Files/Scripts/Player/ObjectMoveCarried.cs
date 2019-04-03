using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveCarried : MonoBehaviour
{
    public float speed = 1f;
    public float angle = 90f;
    public float maxrotation = 120f;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        //clamp
        Vector3 clampedPosition = transform.position;
       //Vector3 clampedRotation = transform.eulerAngles;
        //input
        if (Input.GetKey("a"))
        {
            transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
        }
        //input rotation
        if (Input.GetKey("q"))
        {
            transform.Rotate(angle * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey("e"))
        {
            transform.Rotate(-angle * Time.deltaTime, 0.0f, 0.0f);
        }
        //clamped position
        clampedPosition.y = Mathf.Clamp(transform.position.y, 5.82f, 7.7f);
        clampedPosition.z = Mathf.Clamp(transform.position.z, -9.5f, 16.5f);
        //clamped rotation
        //clampedRotation.x = Mathf.Clamp(transform.eulerAngles.x, -maxrotation, maxrotation);
        //put clamped into transform
        transform.position = clampedPosition;
        //transform.eulerAngles = clampedRotation;
    }
}
