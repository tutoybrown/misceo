using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Phtest : MonoBehaviour
{
    public GameObject tb1, tb2, tb3, tb4, tb5;
    public GameObject me1, me2, me3;
    public GameObject bpb1, bpb2, bpb3;
    public GameObject cr1, cr2, cr3;
    public GameObject bg1, bg2, bg3;
    public GameObject mr1, mr2, mr3;
    public GameObject btb1, btb2, btb3;
    public GameObject pp1, pp2, pp3;
    public GameObject ph1, ph2, ph3;
    public GameObject th1, th2, th3;
    public GameObject correct, wrong, warning, finished;
    public TMP_InputField phguess;
    public int ph, phans, check, error;
    public float phan;

    public void TB()
    {
        if (0 <= ph && ph < 12)
        {
            tb1.SetActive(true);
        }

        if (12 <= ph && ph <= 28)
        {
            tb2.SetActive(true);
        }

        if (28 < ph && ph < 80)
        {
            tb3.SetActive(true);
        }

        if (80 <= ph && ph <= 92)
        {
            tb4.SetActive(true);
        }

        if (92 < ph && ph <= 140)
        {
            tb5.SetActive(true);
        }
    }

    public void ME()
    {
        if (0 <= ph && ph < 30)
        {
            me1.SetActive(true);
        }

        if (30 <= ph && ph <= 44)
        {
            me2.SetActive(true);
        }

        if (44 < ph && ph <= 140)
        {
            me3.SetActive(true);
        }
    }

    public void BPB()
    {
        if (0 <= ph && ph < 30)
        {
            bpb1.SetActive(true);
        }

        if (30 <= ph && ph <= 46)
        {
            bpb2.SetActive(true);
        }

        if (46 < ph && ph <= 140)
        {
            bpb3.SetActive(true);
        }
    }

    public void CR()
    {
        if (0 <= ph && ph < 30)
        {
            cr1.SetActive(true);
        }

        if (30 <= ph && ph <= 50)
        {
            cr2.SetActive(true);
        }

        if (50 < ph && ph <= 140)
        {
            cr3.SetActive(true);
        }
    }

    public void BG()
    {
        if (0 <= ph && ph < 38)
        {
            bg1.SetActive(true);
        }

        if (38 <= ph && ph <= 54)
        {
            bg2.SetActive(true);
        }

        if (54 < ph && ph <= 140)
        {
            bg3.SetActive(true);
        }
    }

    public void MR()
    {
        if (0 <= ph && ph < 44)
        {
            mr1.SetActive(true);
        }

        if (44 <= ph && ph <= 62)
        {
            mr2.SetActive(true);
        }

        if (62 < ph && ph <= 140)
        {
            mr3.SetActive(true);
        }
    }

    public void BTB()
    {
        if (0 <= ph && ph < 60)
        {
            btb1.SetActive(true);
        }

        if (60 <= ph && ph <= 76)
        {
            btb2.SetActive(true);
        }

        if (76 < ph && ph <= 140)
        {
            btb3.SetActive(true);
        }
    }

    public void PP()
    {
        if (0 <= ph && ph < 68)
        {
            pp1.SetActive(true);
        }

        if (68 <= ph && ph <= 84)
        {
            pp2.SetActive(true);
        }

        if (84 < ph && ph <= 140)
        {
            pp3.SetActive(true);
        }
    }

    public void PH()
    {
        if (0 <= ph && ph < 82)
        {
            ph1.SetActive(true);
        }

        if (82 <= ph && ph <= 100)
        {
            ph2.SetActive(true);
        }

        if (100 < ph && ph <= 140)
        {
            ph3.SetActive(true);
        }
    }

    public void TH()
    {
        if (0 <= ph && ph < 93)
        {
            th1.SetActive(true);
        }

        if (93 <= ph && ph <= 105)
        {
            th2.SetActive(true);
        }

        if (105 < ph && ph <= 140)
        {
            th3.SetActive(true);
        }
    }

    public void Game()
    {
        tb1.SetActive(false);
        tb2.SetActive(false);
        tb3.SetActive(false);
        tb4.SetActive(false);
        tb5.SetActive(false);
        me1.SetActive(false);
        me2.SetActive(false);
        me3.SetActive(false);
        bpb1.SetActive(false);
        bpb2.SetActive(false);
        bpb3.SetActive(false);
        cr1.SetActive(false);
        cr2.SetActive(false);
        cr3.SetActive(false);
        bg1.SetActive(false);
        bg2.SetActive(false);
        bg3.SetActive(false);
        mr1.SetActive(false);
        mr2.SetActive(false);
        mr3.SetActive(false);
        btb1.SetActive(false);
        btb2.SetActive(false);
        btb3.SetActive(false);
        pp1.SetActive(false);
        pp2.SetActive(false);
        pp3.SetActive(false);
        ph1.SetActive(false);
        ph2.SetActive(false);
        ph3.SetActive(false);
        th1.SetActive(false);
        th2.SetActive(false);
        th3.SetActive(false);
        ph = UnityEngine.Random.Range(0, 120);
        Debug.Log(ph);
        TB();
        ME();
        BPB();
        CR();
        BG();
        MR();
        BTB();
        PP();
        PH();
        TH();
    }

    public void Check()
    {
        if (true)
        {
            correct.SetActive(false);
            wrong.SetActive(false);
        }
        

        phan = float.Parse(phguess.text) * 10;
        phans = Convert.ToInt32(phan);

        error++;

        // 0 - 11
        if (ph <= 11)
        {
            if (phans <= 11)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (phans > 11)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 12 - 28
        if (12 <= ph && ph <= 28)
        {
            if (12 <= phans && phans <= 28)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (12 > phans || phans > 28)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 29 - 29
        if (29 <= ph && ph <= 29)
        {
            if (29 <= phans && phans <= 29)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (29 > phans || phans > 29)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 30 - 37
        if (30 <= ph && ph <= 37)
        {
            if (30 <= phans && phans <= 37)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (30 > phans || phans > 37)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 38 - 44
        if (38 <= ph && ph <= 44)
        {
            if (38 <= phans && phans <= 44)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (38 > phans || phans > 44)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 45 - 46
        if (45 <= ph && ph <= 46)
        {
            if (45 <= phans && phans <= 46)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (45 > phans || phans > 46)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 47 - 50
        if (47 <= ph && ph <= 50)
        {
            if (47 <= phans && phans <= 50)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (47 > phans || phans > 50)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 51 - 53
        if (51 <= ph && ph <= 53)
        {
            if (51 <= phans && phans <= 53)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (51 > phans || phans > 53)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 54 - 59
        if (54 <= ph && ph <= 59)
        {
            if (54 <= phans && phans <= 59)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (54 > phans || phans > 59)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 60 - 62
        if (60 <= ph && ph <= 62)
        {
            if (60 <= phans && phans <= 62)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (60 > phans || phans > 62)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 63 - 67
        if (63 <= ph && ph <= 67)
        {
            if (63 <= phans && phans <= 67)
            {
                correct.SetActive(true);
                check++;
                error = 0;
            }

            if (63 > phans || phans > 67)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 68 - 76
        if (68 <= ph && ph <= 76)
        {
            if (68 <= phans && phans <= 76)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (68 > phans || phans > 76)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 77 - 81
        if (77 <= ph && ph <= 81)
        {
            if (77 <= phans && phans <= 81)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (77 > phans || phans > 81)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 82 - 84
        if (82 <= ph && ph <= 84)
        {
            if (82 <= phans && phans <= 84)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (82 > phans || phans > 84)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 85 - 92
        if (85 <= ph && ph <= 92)
        {
            if (85 <= phans && phans <= 92)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (85 > phans || phans > 92)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 93 - 100
        if (93 <= ph && ph <= 100)
        {
            if (93 <= phans && phans <= 100)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (93 > phans || phans >= 100)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 101 - 105
        if (101 <= ph && ph <= 105)
        {
            if (101 <= phans && phans <= 105)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (101 > phans || phans > 105)
            {
                error++;
                wrong.SetActive(true);
            }
        }
        // 105
        if (106 <= ph && ph <= 140)
        {
            if (106 <= phans && phans <= 140)
            {
                check++;
                error = 0;
                correct.SetActive(true);
            }

            if (106 > phans || phans > 140)
            {
                error++;
                wrong.SetActive(true);
            }
        }

        if (check >= 5)
        {
            finished.SetActive(true);
        }

        if (error >= 5)
        {
            warning.SetActive(true);
        }

        if (error < 5)
        {
            warning.SetActive(false);
        }

    }

    public void Clear(){

            tb1.SetActive(false);
            tb2.SetActive(false);
            tb3.SetActive(false);
            tb4.SetActive(false);
            tb5.SetActive(false);
            me1.SetActive(false);
            me2.SetActive(false);
            me3.SetActive(false);
            bpb1.SetActive(false);
            bpb2.SetActive(false);
            bpb3.SetActive(false);
            cr1.SetActive(false);
            cr2.SetActive(false);
            cr3.SetActive(false);
            bg1.SetActive(false);
            bg2.SetActive(false);
            bg3.SetActive(false);
            mr1.SetActive(false);
            mr2.SetActive(false);
            mr3.SetActive(false);
            btb1.SetActive(false);
            btb2.SetActive(false);
            btb3.SetActive(false);
            pp1.SetActive(false);
            pp2.SetActive(false);
            pp3.SetActive(false);
            ph1.SetActive(false);
            ph2.SetActive(false);
            ph3.SetActive(false);
            th1.SetActive(false);
            th2.SetActive(false);
            th3.SetActive(false);
            correct.SetActive(false);
            wrong.SetActive(false);
    }
}
