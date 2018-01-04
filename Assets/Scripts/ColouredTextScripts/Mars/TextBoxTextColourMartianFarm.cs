using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourMartianFarm : MonoBehaviour
{
    public Text textBoxText;
    private string colour1;
    private string colour2;
    private string colour3;
    private string colourEnd;
    private string red;
    private string green;

    void Start()
    {
        colour1 = "<color=red>";
        colour2 = "<color=red>";
        colour3 = "<color=red>";
        red = "<color=red>";
        colourEnd = "</color>";
        green = "<color=green>";
    }

    void SetText()
    {
        textBoxText.text = "Requires: \n" + colour1 + "1 Taskmaster" + colourEnd + "\n" + colour2 + "1 Builder" + colourEnd + "\n" + colour3 + "10 Peons" + colourEnd;
    }

    void Update()
    {
        GameObject marsinterface = GameObject.Find("MarsInterface");
        MarsController mif = marsinterface.GetComponent<MarsController>();

        SetText();

        if (mif.martianTaskMasterCount >= 1)
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

        if (mif.martianBuilderCount >= 1)
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

        if (mif.martianPeonCount >= 10)
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
    }
}
