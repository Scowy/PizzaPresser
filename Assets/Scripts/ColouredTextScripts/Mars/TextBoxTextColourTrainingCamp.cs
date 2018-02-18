using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourTrainingCamp : MonoBehaviour
{
    public Text textBoxText;
    public GameObject marsInterface;
    private string colour1;
    private string colourEnd;
    private string red;
    private string green;

    void Start()
    {
        colour1 = "<color=red>";
        red = "<color=red>";
        colourEnd = "</color>";
        green = "<color=green>";
    }

    void SetText()
    {
        textBoxText.text = "Requires: \n" + colour1 + "5 Peons" + colourEnd;
    }

    void Update()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        SetText();

        if (mif.martianPeonCount >= 5)
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
    }
}
