using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info_v2 : MonoBehaviour
{
    public GameObject info, menu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(!menu.gameObject.activeSelf);
            info.SetActive(!info.gameObject.activeSelf);
            
        }

        
    }

}
