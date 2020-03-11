using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solutions : MonoBehaviour
{
    public bool copA, silA, zinA;
    public bool CUA, AGA, ZNA;
    public bool copB, silB, zinB;
    public bool CUB, AGB, ZNB;
    public bool on, A1, A2, B1, B2, left, right, check;
    public static GameObject lelectron, relectron, pfoursix, nfoursix, ponefive, nonefive, poneone, noneone, zero;
    public GameObject lelectro, relectro, pfoursi, nfoursi, ponefiv, nonefiv, poneon, noneon, zer, warn, finished;
    public bool one, two, three, four, five, six;
    public int tester;
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
        zero = zer;
    }

    // Metals A
    public void CopA()
    {
            copA = true;
            silA = false;
            zinA = false;

            A1 = true;

            Debug.Log("CopA");
    }
    public void SilA()
    {
       
            copA = false;
            silA = true;
            zinA = false;

            A1 = true;

            Debug.Log("SilA");
        
    }
    public void ZinA()
    {
        
            copA = false;
            silA = false;
            zinA = true;

            A1 = true;

            Debug.Log("ZinA");
        
    }
    //Metals B
    public void CopB()
    {
        
            copB = true;
            silB = false;
            zinB = false;

            B1 = true;

            Debug.Log("CopB");
        
    }
    public void SilB()
    {
        
            copB = false;
            silB = true;
            zinB = false;

            B1 = true;

            Debug.Log("SilB");
        
    }
    public void ZinB()
    {
        
            copB = false;
            silB = false;
            zinB = true;

            B1 = true;

            Debug.Log("ZinB");
        
    }
    // Solutions A
    public void CuA()
    {
        
            CUA = true;
            AGA = false;
            ZNA = false;

            A2 = true;

            Debug.Log("CuA");
        
    }
    public void AgA()
    {
        
            CUA = false;
            AGA = true;
            ZNA = false;

            A2 = true;

            Debug.Log("AgA");
        
    }
    public void ZiNA()
    {
        
            CUA = false;
            AGA = false;
            ZNA = true;

            A2 = true;

            Debug.Log("ZiNA");
        
    }
    // Solutions B
    public void CuB()
    {
        
            CUB = true;
            AGB = false;
            ZNB = false;

            B2 = true;

            Debug.Log("CuB");
        
    }
    public void AgB()
    {
        
            CUB = false;
            AGB = true;
            ZNB = false;

            B2 = true;

            Debug.Log("AgB");

    }
    public void ZiNB()
    {
        
            CUB = false;
            AGB = false;
            ZNB = true;

            B2 = true;

            Debug.Log("ZiNB");

    }

    public void test()
    {
        if (check == true)
        {
            pfoursix.SetActive(false);
            nfoursix.SetActive(false);
            ponefive.SetActive(false);
            nonefive.SetActive(false);
            poneone.SetActive(false);
            noneone.SetActive(false);
            zero.SetActive(false);
            lelectron.SetActive(false);
            relectron.SetActive(false);
            electron();
            on = false;
            check = false;  
        }
        
        if (A1 == true && A2 == true && B1 == true && B2 == true)
        {

            // Copper and Zinc
            if (CUA == true && copA == true && ZNB == true && zinB == true)
            {
                poneone.SetActive(true);
                Debug.Log("CZ");
                on = true;
                right = true;
                tester = 0;
                one = true;
            }

            if (ZNA == true && zinA == true && CUB == true && copB == true)
            {
                noneone.SetActive(true);
                Debug.Log("ZC");
                on = true;
                left = true;
                tester = 0;
                two = true;
            }

            // Copper and Silver

            if (CUA == true && copA == true && AGB == true && silB == true)
            {
                nfoursix.SetActive(true);
                Debug.Log("CS");
                on = true;
                left = true;
                tester = 0;
                three = true;
            }

            if (AGA == true && silA == true && CUB == true && copB == true)
            {
                pfoursix.SetActive(true);
                Debug.Log("SC");
                on = true;
                right = true;
                tester = 0;
                four = true;
            }

            // Zinc and Silver

            if (ZNA == true && zinA == true && AGB == true && silB == true)
            {
                nonefive.SetActive(true);
                Debug.Log("ZS");
                on = true;
                left = true;
                tester = 0;
                five = true;
            }

            if (AGA == true && silA == true && ZNB == true && zinB == true)
            {
                Debug.Log("SZ");
                ponefive.SetActive(true);
                on = true;
                right = true;
                tester = 0;
                six = true;
            }
            
        }

        if (on == false)
        {
            zero.SetActive(true);
            left = false;
            right = false;
            tester++;
        }
        
        if (tester == 10)
        {
            Debug.Log("Same Elements");
            warn.SetActive(true);
        }

        if (tester == 0)
        {
            warn.SetActive(false);
        }

        if (one == true && two == true && three == true && four == true && five == true && six == true)
        {
            finished.SetActive(true);
        }

        check = true;

    }

    public void electron()
    {
        if (left == true)
        {
            lelectron.SetActive(true);
            left = false;
        }
        if (right == true)
        {
            relectron.SetActive(true);
            right = false;
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
        zero.SetActive(false);
    }
}


