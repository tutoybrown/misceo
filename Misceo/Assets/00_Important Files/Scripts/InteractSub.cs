using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InteractSub : MonoBehaviour
{
    public static int playerlocation;

    public static Transform worktable1a, worktable1b, worktable2a, worktable2b, worktable3a, worktable3b, worktable4a, worktable4b, worktable5a, worktable5b;
    public static Camera main, worktable1, worktable2, worktable3, worktable4, worktable5;

    public Transform worktale1a, worktale1b;

    // worktale2a, worktale2b, worktale3a, worktale3b
    //, worktable4a, worktable4b, worktable5a, worktable5b
    public Camera mains, worktable1s;
        
        //, worktable2, worktable3, worktable4, worktable5;

    void Start()
    {
        worktable1a = worktale1a;
        worktable1b = worktale1b;
        main = mains;
        worktable1 = worktable1s;
    }
}
