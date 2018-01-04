using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourPizzaMoonBase : MonoBehaviour
{
    public Text textBoxText;
    private string colour1;
    private string colour2;
    private string colour3;
    private string colour4;
    private string colour5;
    private string colour6;
    private string colour7;
    private string colour8;
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
        colour7 = "<color=red>";
        colour8 = "<color=red>";
        red = "<color=red>";
        colourEnd = "</color>";
        green = "<color=green>";
    }

    void SetText()
    {
        textBoxText.text = "Requires: \n" + colour1 + "512 Slaves" + colourEnd + "\n" + colour2 + "128 Cleaners" + colourEnd + "\n" + colour3 + "64 Operators" + colourEnd + "\n" + colour4 + "32 Scientists" + colourEnd + "\n" + colour5 + "16 Astronauts" + colourEnd + "\n" + colour6 + "50 Astronauts" + colourEnd + "\n" + colour7 + "2 Space Elevators" + colourEnd + "\n" + colour8 + "1 Moon Base" + colourEnd;
    }

    void Update()
    {
            GameObject earthinterface = GameObject.Find("EarthInterface");
            EarthController eif = earthinterface.GetComponent<EarthController>();

            SetText();

            if (eif.slaveCount >= 512)
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

            if (eif.cleanerCount >= 128)
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

            if (eif.operatorCount >= 64)
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

            if (eif.scientistCount >= 32)
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

            if (eif.astronautCount >= 16)
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

            if (eif.scrapMetalCount >= 50)
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

            if (eif.spaceElevatorCount >= 2)
            {
                if (colour7 == red)
                {
                    colour7 = green;
                }
            }
            else if (colour7 == green)
            {
                colour7 = red;
            }

            if (eif.moonBaseCount >= 1)
            {
                if (colour8 == red)
                {
                    colour8 = green;
                }
            }
            else if (colour8 == green)
            {
                colour8 = red;
            }
    }
}
