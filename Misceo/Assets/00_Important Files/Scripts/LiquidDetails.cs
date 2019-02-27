using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidDetails : MonoBehaviour
{
    public static string chemical;
    public static Material Material;
    void Start()
    {
        
    }

    public void MakeName(string x)
    {
        chemical = x;
    }

    public void MakeMaterial(Material x)
    {
        Material = x;
    }
}
