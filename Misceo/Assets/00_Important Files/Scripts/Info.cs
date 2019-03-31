using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject Menu, TutorialLevel, player;
    public Camera main, ui;
    public int on;

    void Start()
    {
        main.enabled = true;
        ui.enabled = false;
        on = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("y") && on == 0)
        {
            ui.enabled = !main.enabled;
            main.enabled = !ui.enabled;

            Menu.SetActive(false);
            TutorialLevel.SetActive(false);

            //player.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            on = 1;
        }

        if (Input.GetKeyDown("i") && on == 1)
        {

            Menu.SetActive(true);
            TutorialLevel.SetActive(true);
            //player.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            ui.enabled = !main.enabled;
            main.enabled = !ui.enabled;

            on = 0;

        }

        
    }

}
