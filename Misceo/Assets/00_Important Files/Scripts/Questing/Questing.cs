using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Questing : MonoBehaviour
{
    public static bool Movement, PressE , OpenDoor, ActPour, Hotplate = false;
    public int scene;
    
    void Update()
    {
        if (Movement && PressE && OpenDoor && ActPour && Hotplate && Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(scene);
        }

    }
}
