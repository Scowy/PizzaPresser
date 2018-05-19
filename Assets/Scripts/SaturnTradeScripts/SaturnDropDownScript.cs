using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaturnDropDownScript : MonoBehaviour
{
    public Dropdown dropDownMenu;
    public GameObject[] dropDownList;
    private GameObject startMenu;
    private GameObject endMenu;

    void Start()
    {
        startMenu = dropDownList[0];
    }

    public void DropDownChange(int index)
    {
        endMenu = dropDownList[index];
        startMenu.SetActive(false);
        endMenu.SetActive(true);
        startMenu = endMenu;
    }
}
