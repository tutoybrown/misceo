using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public int scene;
    public GameObject hud;



    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e") && other.tag == "MainCamera")
        {
            SceneManager.LoadScene(scene);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hud.SetActive(true);
        }

    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            hud.SetActive(false);
        }

    }

    
}
