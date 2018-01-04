using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourPizzaSuperDrill : MonoBehaviour
{
    public Text textBoxText;
    private string colour1;
    private string colour2;
    private string colour3;
    private string colour4;
    private string colour5;
    private string colour6;
    private string colourEnd;
    private string red;
    private string green;

    void Start()
    {
        colour1 = "<color=red>";
        colour2 = "<color=red>";
        colour3 = "<color=red>";
        colour4 = "<color=red>";
        colour5 = "<color=red>";
        colour6 = "<color=red>";
        red = "<color=red>";
        colourEnd = "</color>";
        green = "<color=green>";
    }

    void SetText()
    {
        textBoxText.text = "Requires: \n" + colour1 + "256 Slaves" + colourEnd + "\n" + colour2 + "64 Cleaners" + colourEnd + "\n" + colour3 + "32 Operators" + colourEnd + "\n" + colour4 + "16 Scientists" + colourEnd + "\n" + colour5 + "30 Scrap Metal" + colourEnd + "\n" + colour6 + "1 Super Drill" + colourEnd;
    }

    void Update()
    {
            GameObject earthinterface = GameObject.Find("EarthInterface");
            EarthController eif = earthinterface.GetComponent<EarthController>();

            SetText();

            if (eif.slaveCount >= 256)
            {
                if (colour1 == red)
                {
                    colour1 = green;
                }
            }
            else if (colour1 == green)
            {
                colour1 = red;
            }

            if (eif.cleanerCount >= 64)
            {
                if (colour2 == red)
                {
                    colour2 = green;
                }
            }
            else if (colour2 == green)
            {
                colour2 = red;
            }

            if (eif.operatorCount >= 32)
            {
                if (colour3 == red)
                {
                    colour3 = green;
                }
            }
            else if (colour3 == green)
            {
                colour3 = red;
            }

            if (eif.scientistCount >= 16)
            {
                if (colour4 == red)
                {
                    colour4 = green;
                }
            }
            else if (colour4 == green)
            {
                colour4 = red;
            }

            if (eif.scrapMetalCount >= 30)
            {
                if (colour5 == red)
                {
                    colour5 = green;
                }
            }
            else if (colour5 == green)
            {
                colour5 = red;
            }

            if (eif.superDrillCount >= 1)
            {
                if (colour6 == red)
                {
                    colour6 = green;
                }
            }
            else if (colour6 == green)
            {
                colour6 = red;
            }
    }
}
