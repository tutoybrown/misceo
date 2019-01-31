using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float speed = 25.0f;
    public float height = 10.0f;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        CharacterController playercontrol = GetComponent<CharacterController>();
        //Height
        playercontrol.height = height;
        //Move Forward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curspeed1 = speed * Input.GetAxis("Vertical");
        playercontrol.SimpleMove(forward*curspeed1);
        //Move Sideways
        Vector3 side = transform.TransformDirection(Vector3.right);
        float curspeed2 = speed * Input.GetAxis("Horizontal");
        playercontrol.SimpleMove(side * curspeed2);

    }
}

