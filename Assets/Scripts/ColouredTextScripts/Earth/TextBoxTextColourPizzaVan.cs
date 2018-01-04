using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxTextColourPizzaVan : MonoBehaviour
{
    public Text textBoxText;
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
        textBoxText.text = "Requires: \n" + colour1 + "2 Slaves" + colourEnd + "\n" + colour2 + "1 Van" + colourEnd;
    }

    void Update()
    {
            GameObject earthinterface = GameObject.Find("EarthInterface");
            EarthController eif = earthinterface.GetComponent<EarthController>();

            SetText();

            if (eif.slaveCount >= 2)
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

            if (eif.vanCount >= 1)
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
