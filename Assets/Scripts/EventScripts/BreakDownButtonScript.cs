using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakDownButtonScript : MonoBehaviour
{
    private GameObject breakDownButton;
    private Slider breakDownSlider;

    void Start()
    {
        breakDownButton = this.gameObject;
        breakDownSlider = GameObject.FindGameObjectWithTag("BreakDownSlider").GetComponent<Slider>();
    }

    public void BreakDownButtonClick()
    {
        breakDownSlider.value += 10;
        EarthEventScript ees = GameObject.Find("EarthInterface").GetComponent<EarthEventScript>();
        ees.b -= 1;
        Destroy(breakDownButton);
    }
}
