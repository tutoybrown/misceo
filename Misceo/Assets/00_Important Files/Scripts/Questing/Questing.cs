using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Questing : MonoBehaviour
{
    public static bool PressE = false;
    public static bool OpenDoor = false;
    public static bool ActPour = false;
    public static bool Hotplte = false;
    public bool inside = false;
    public int scene;
    
    void Update()
    {
        if (PressE && OpenDoor && ActPour && Hotplte)
        {
            inside = true;
        }

        if (PressE && OpenDoor && ActPour && Hotplte && Input.GetKeyDown(KeyCode.Backslash))
        {
            Debug.Log("Waiting");
            SceneManager.LoadScene(scene);
        }

        
    }

    void OnGUI()
    {
        if (inside)
        {
            GUI.Label(new Rect(Screen.width / 2 + 25, Screen.height - 50, 175, 45), "Press Backslash to exit");
        }
    }
}
