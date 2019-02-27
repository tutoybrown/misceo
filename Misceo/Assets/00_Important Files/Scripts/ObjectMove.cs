﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
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
        if (Input.GetKeyDown("j"))
        {
            transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKeyDown("l"))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKeyDown("i"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKeyDown("k"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0, Space.World);
        }

        if (Input.GetKeyDown("u"))
        {
            transform.Rotate(angle * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown("o"))
        {
            transform.Rotate(angle * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
