﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public int scene;

    public void PlayGame()
    {
        SceneManager.LoadScene(scene);
    }
}
