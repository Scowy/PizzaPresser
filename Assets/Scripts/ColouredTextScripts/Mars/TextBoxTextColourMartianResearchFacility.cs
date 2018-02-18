using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourMartianResearchFacility : MonoBehaviour
{
    public Text textBoxText;
    public GameObject marsInterface;
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
        textBoxText.text = "Requires: \n" + colour1 + "1 Taskmasters" + colourEnd + "\n" + colour2 + "10 Builders" + colourEnd + "\n" + colour3 + "10 Engineers" + colourEnd + "\n" + colour4 + "10 Scientists" + colourEnd + "\n" + colour5 + "10 Doctors" + colourEnd + "\n" + colour6 + "10 Peons" + colourEnd;
    }

    void Update()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

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

        if (mif.martianEngineerCount >= 10)
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

        if (mif.martianScientistCount >= 10)
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

        if (mif.martianDoctorCount >= 10)
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

        if (mif.martianPeonCount >= 10)
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
