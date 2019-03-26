using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public int scene;
    public bool inside;



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
            inside = true;
        }

    }
    void OnGUI()
    {
        if (inside)
        {
            GUI.Label(new Rect(Screen.width / 2 + 25, Screen.height - 50, 175, 45), "Press E to exit");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inside = false;
        }

    }

    
}
