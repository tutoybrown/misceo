using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 vector;
    public void Make()
    {
       
            Instantiate(prefab, vector , Quaternion.identity); 
    }
}
