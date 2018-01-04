using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourPizzaPalace : MonoBehaviour
{
    public Text textBoxText;
    private string colour1;
    private string colour2;
    private string colour3;
    private string colour4;
    private string colourEnd;
    private string red;
    private string green;

    void Start()
    {
        colour1 = "<color=red>";
        colour2 = "<color=red>";
        colour3 = "<color=red>";
        colour4 = "<color=red>";
        red = "<color=red>";
        colourEnd = "</color>";
        green = "<color=green>";
    }

    void SetText()
    {
        textBoxText.text = "Requires: \n" + colour1 + "16 Slaves" + colourEnd + "\n" + colour2 + "4 Cleaners" + colourEnd + "\n" + colour3 + "2 Managers" + colourEnd + "\n" + colour4 + "1 Palace" + colourEnd;
    }

    void Update()
    {
            GameObject earthinterface = GameObject.Find("EarthInterface");
            EarthController eif = earthinterface.GetComponent<EarthController>();

            SetText();

            if (eif.slaveCount >= 16)
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

            if (eif.cleanerCount >= 4)
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

            if (eif.managerCount >= 2)
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

            if (eif.palaceCount >= 1)
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
    }
}
