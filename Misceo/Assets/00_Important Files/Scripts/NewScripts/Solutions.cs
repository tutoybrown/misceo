using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solutions : MonoBehaviour
{
    public static bool copA, silA, zinA;
    public static bool CUA, AGA, ZNA;
    public static bool copB, silB, zinB;
    public static bool CUB, AGB, ZNB;
    public static bool on, A1, A2, B1, B2, left, right;
    public static GameObject lelectron, relectron, pfoursix, nfoursix, ponefive, nonefive, poneone, noneone;
    public GameObject lelectro, relectro, pfoursi, nfoursi, ponefiv, nonefiv, poneon, noneon;
    // Start is called before the first frame update
    public void Start()
    {
        lelectron = lelectro;
        relectron = relectro;
        pfoursix = pfoursi;
        nfoursix = nfoursi;
        ponefive = ponefiv;
        nonefive = nonefiv;
        poneone = poneon;
        noneone = noneon;
    }

    // Metals A
    public void CopA()
    {
        if (on == false)
        {
            copA = true;
            silA = false;
            zinA = false;

            A1 = true;
        }
    }
    public void SilA()
    {
        if (on == false)
        {
            copA = false;
            silA = true;
            zinA = false;

            A1 = true;
        }
    }
    public void ZinA()
    {
        if (on == false)
        {
            copA = false;
            silA = false;
            zinA = true;

            A1 = true;
        }
    }
    //Metals B
    public void CopB()
    {
        if (on == false)
        {
            copB = true;
            silB = false;
            zinB = false;

            B1 = true;
        }
    }
    public void SilB()
    {
        if (on == false)
        {
            copB = false;
            silB = true;
            zinB = false;

            B1 = true;
        }
    }
    public void ZinB()
    {
        if (on == false)
        {
            copB = false;
            silB = false;
            zinB = true;

            B1 = true;
        }
    }
    // Solutions A
    public void CuA()
    {
        if (on == false)
        {
            CUA = true;
            AGA = false;
            ZNA = false;

            A2 = true;
        }
    }
    public void AgA()
    {
        if (on == false)
        {
            CUA = false;
            AGA = true;
            ZNA = false;

            A2 = true;
        }
    }
    public void ZiNA()
    {
        if (on == false)
        {
            CUA = false;
            AGA = false;
            ZNA = true;

            A2 = true;
        }
    }
    // Solutions B
    public void CuB()
    {
        if (on == false)
        {
            CUB = true;
            AGB = false;
            ZNB = false;

            B2 = true;
        }
    }
    public void AgB()
    {
        if (on == false)
        {
            CUA = false;
            AGA = true;
            ZNA = false;

            B2 = true;
        }
    }
    public void ZiNB()
    {
        if (on == false)
        {
            CUB = false;
            AGB = false;
            ZNB = true;

            B2 = true;
        }
    }

    public void test()
    {
        if (A1 == true && A2 == true && A2 == true && A2 == true)
        {

            // Copper and Zinc
            if (CUA == true && copA == true && ZNB == true && zinB == true)
            {
                Debug.Log("Hello");
                poneone.SetActive(true);
                on = true;
                right = true;
            }

            if (ZNA == true && zinA == true && CUB == true && copB == true)
            {
                noneone.SetActive(true);
                on = true;
                left = true;
            }

            // Copper and Silver

            if (CUA == true && copA == true && AGB == true && silB == true)
            {
                nfoursix.SetActive(true);
                on = true;
                left = true;
            }

            if (AGA == true && silA == true && CUB == true && copB == true)
            {
                pfoursix.SetActive(true);
                on = true;
                right = true;
            }

            // Zinc and Silver

            if (ZNA == true && zinA == true && AGB == true && silB == true)
            {
                nonefive.SetActive(true);
                on = true;
                left = true;
            }

            if (AGA == true && silA == true && ZNB == true && zinB == true)
            {
                ponefive.SetActive(true);
                on = true;
                right = true;
            }
        }
    }

    public void electron()
    {
        if (left == true)
        {
            lelectron.SetActive(true);
        }
        if (right == true)
        {
            relectron.SetActive(true);
        }
    }

    public void Stop()
    {
        copA = false;
        silA = false;
        zinA = false;
        CUA = false;
        AGA = false;
        ZNA = false;
        copB = false;
        silB = false;
        zinB = false;
        CUB = false;
        AGB = false;
        ZNB = false;
        on = false;
        A1 = false;
        A2 = false;
        B1 = false;
        B2 = false;
        left = false;
        right = false;
        lelectron.SetActive(false);
        relectron.SetActive(false);
        pfoursix.SetActive(false);
        nfoursix.SetActive(false);
        ponefive.SetActive(false);
        nonefive.SetActive(false);
        poneone.SetActive(false);
        noneone.SetActive(false);
    }
}


