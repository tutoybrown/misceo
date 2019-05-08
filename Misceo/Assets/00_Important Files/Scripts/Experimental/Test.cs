using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public int scene;
    

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
