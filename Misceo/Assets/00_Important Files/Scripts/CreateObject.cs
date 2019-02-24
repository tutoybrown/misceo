using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
       
            Instantiate(prefab, new Vector3(-2.0442f, 0.4336F, -0.1049F), Quaternion.identity); 
    }
}
