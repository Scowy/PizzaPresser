using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourMartianPowerPlant : MonoBehaviour
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
        textBoxText.text = "Requires: \n" + colour1 + "3 Taskmasters" + colourEnd + "\n" + colour2 + "10 Builders" + colourEnd + "\n" + colour3 + "15 Engineers" + colourEnd + "\n" + colour4 + "30 Peons" + colourEnd;
    }

    void Update()
    {
        GameObject marsinterface = GameObject.Find("MarsInterface");
        MarsController mif = marsinterface.GetComponent<MarsController>();

        SetText();

        if (mif.martianTaskMasterCount >= 3)
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

        if (mif.martianBuilderCount >= 10)
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

        if (mif.martianEngineerCount >= 15)
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

        if (mif.martianPeonCount >= 30)
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
