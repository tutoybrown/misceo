using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest_21 : MonoBehaviour
{

    
    public GameObject[] gameObjects;
    public int scene;
    
    public static bool[] Quest = new bool[5];
    public static bool[] Unvisited = new bool[5] { true, true, true, true, true};

    void Start()
    {
        //Quest[0] = true;
    }
        
    void Update()
    {
        for (int i = 0; i < Quest.Length; i++)
        {
            if (Quest[i] && Unvisited[i])
            {
                gameObjects[i].SetActive(true);
            }

            if (!Quest[i] && !Unvisited[i])
            {
                gameObjects[i].SetActive(false);
            }
        }

        if (Quest[Quest.Length - 1])
        {
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                SceneManager.LoadScene(scene);
            }
        }
        
    }

    void OnKeyPress()
    {
        
    }
}
