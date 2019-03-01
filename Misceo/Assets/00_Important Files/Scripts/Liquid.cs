using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid : MonoBehaviour
{
    public string liquid;
    public Material material;
    public Shader shader;

    void Start()
    {
        liquid = LiquidDetails.chemical;
        material = LiquidDetails.Material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
