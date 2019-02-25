using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform prefab;
    public Vector3 vector = new Vector3(-2.0442f, 0.4336F, -0.1049F);
    void Start()
    {
       
            Instantiate(prefab, vector , Quaternion.identity); 
    }
}
