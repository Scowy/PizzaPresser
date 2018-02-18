using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourMartianMine : MonoBehaviour
{
    public Text textBoxText;
    public GameObject marsInterface;
    private string colour1;
    private string colour2;
    private string colourEnd;
    private string red;
    private string green;

    void Start()
    {
        colour1 = "<color=red>";
        colour2 = "<color=red>";
        red = "<color=red>";
        colourEnd = "</color>";
        green = "<color=green>";
    }

    void SetText()
    {
        textBoxText.text = "Requires: \n" + colour1 + "1 Taskmaster" + colourEnd + "\n" + colour2 + "5 Builders" + colourEnd;
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

        if (mif.martianBuilderCount >= 5)
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
    }
}
