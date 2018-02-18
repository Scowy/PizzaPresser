using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipConstructionButtonChangeScript : MonoBehaviour
{
    private int i;
    private int[] buyStatusCheckValue = { 0, 0, 0, 0, 0, 0, 0, 0 };
    private string buttonName;

    public GameObject marsInterface;

    public Button spaceshipConstructionButton;
    public Text buttonText;
    public Button leftArrow;
    public Button rightArrow;
    public Text requirementText1;
    public Text requirementText2;
    public Text requirementText3;
    public Text requirementText4;

    public Text checkListMainStructureText;
    public Text checkListMainframeText;
    public Text checkListPowerCoreText;
    public Text checkListLivingQuartersText;
    public Text checkListCafeteriaText;
    public Text checkListMedicalBayText;
    public Text checkListScienceLabsText;
    public Text checkListSpaceCannonsText;

    void Start ()
    {
        i = 1;
        ButtonTextChange();
    }

    /// <summary>
    /// Switches between the items available to buy
    /// </summary>

    public void NextItem()
    {
        // This is part of a fix to prevent players from buying the same item twice
        if (spaceshipConstructionButton.interactable == false)
        {
            spaceshipConstructionButton.interactable = true;
        }

        i += 1;

        // Stops i from exceeding the array size and cycles it back
        if (i >= 9)
        {
            i = 1;
        }

        // This removes bought items from being viewed
        while (buyStatusCheckValue[i - 1] == 1)
        {
            i += 1;

            if (i >= 9)
            {
                i = 1;
            }
        }
        ButtonTextChange();
    }

    public void PreviousItem()
    {
        i -= 1;

        if (i <= 0)
        {
            i = 8;
        }

        while (buyStatusCheckValue[i - 1] == 1)
        {
            i -= 1;

            if (i <= 0)
            {
                i = 8;
            }
        }
        ButtonTextChange();
    }
	
    /// <summary>
    /// Controls the action taken when the button is clicked
    /// </summary>

    public void ButtonClick()
    {
        if (i == 1)
        {
            BuyMainStructure();
        }
        if (i == 2)
        {
            BuyMainFrame();
        }
        if (i == 3)
        {
            BuyPowerCore();
        }
        if (i == 4)
        {
            BuyLivingQuarters();
        }
        if (i == 5)
        {
            BuyCafeteria();
        }
        if (i == 6)
        {
            BuyMedicalBay();
        }
        if (i == 7)
        {
            BuyScienceLabs();
        }
        if (i == 8)
        {
            BuySpaceCannons();
        }
    }

    /// <summary>
    /// Changes all the text when switching between items
    /// </summary>

    void ButtonTextChange()
    {
        if (i == 1)
        {
            buttonName = "Main Structure";
            buttonText.text = buttonName;
            requirementText1.text = "100,000 Rock";
            requirementText1.color = new Color(169f / 255f, 133f / 255f, 0f);
            requirementText2.text = "100,000 Metal";
            requirementText2.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText3.enabled = false;
            requirementText4.enabled = false;
        }
        if (i == 2)
        {
            buttonName = "Mainframe";
            buttonText.text = buttonName;
            requirementText1.text = "10,000 Metal";
            requirementText1.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText2.text = "20,000 Energy";
            requirementText2.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText3.enabled = false;
            requirementText4.enabled = false;
        }
        if (i == 3)
        {
            buttonName = "Power Core";
            buttonText.text = buttonName;
            requirementText1.text = "20,000 Metal";
            requirementText1.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText2.text = "100,000 Energy";
            requirementText2.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText3.enabled = false;
            requirementText4.enabled = false;
        }
        if (i == 4)
        {
            buttonName = "Living Quarters";
            buttonText.text = buttonName;
            requirementText1.text = "10,000 Rock";
            requirementText1.color = new Color(169f / 255f, 133f / 255f, 0f);
            requirementText2.text = "10,000 Metal";
            requirementText2.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText3.text = "15,000 Energy";
            requirementText3.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText4.text = "30,000 Food";
            requirementText3.enabled = true;
            requirementText4.enabled = true;

        }
        if (i == 5)
        {
            buttonName = "Cafeteria";
            buttonText.text = buttonName;
            requirementText1.text = "10,000 Metal";
            requirementText1.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText2.text = "10,000 Energy";
            requirementText2.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText3.text = "3,000,000 Food";
            requirementText3.color = new Color(0f, 0f, 0f);
            requirementText3.enabled = true;
            requirementText4.enabled = false;
        }
        if (i == 6)
        {
            buttonName = "Medical Bay";
            buttonText.text = buttonName;
            requirementText1.text = "15,000 Metal";
            requirementText1.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText2.text = "20,000 Energy";
            requirementText2.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText3.text = "20,000 Food";
            requirementText3.color = new Color(0f, 0f, 0f);
            requirementText3.enabled = true;
            requirementText4.enabled = false;
        }
        if (i == 7)
        {
            buttonName = "Science Labs";
            buttonText.text = buttonName;
            requirementText1.text = "15,000 Rock";
            requirementText1.color = new Color(169f / 255f, 133f / 255f, 0f);
            requirementText2.text = "25,000 Metal";
            requirementText2.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText3.text = "40,000 Energy";
            requirementText3.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText4.text = "10,000 Food";
            requirementText3.enabled = true;
            requirementText4.enabled = true;
        }
        if (i == 8)
        {
            buttonName = "Space Cannons";
            buttonText.text = buttonName;
            requirementText1.text = "50,000 Rock";
            requirementText1.color = new Color(169f / 255f, 133f / 255f, 0f);
            requirementText2.text = "10,000 Metal";
            requirementText2.color = new Color(182f / 255f, 192f / 255f, 175f / 255f);
            requirementText3.text = "10,000 Energy";
            requirementText3.color = new Color(219f / 255f, 192f / 219f, 0f);
            requirementText3.enabled = true;
            requirementText4.enabled = false;
        }
    }

    /// <summary>
    /// This ends the objective once the player has bought all the items, used after every item purchase
    /// </summary>

    void ObjectiveCompletionCheck()
    {
        if (buyStatusCheckValue[0] == 1 && buyStatusCheckValue[1] == 1 && buyStatusCheckValue[2] == 1 && buyStatusCheckValue[3] == 1 && buyStatusCheckValue[4] == 1 && buyStatusCheckValue[5] == 1 && buyStatusCheckValue[6] == 1 && buyStatusCheckValue[7] == 1)
        {
            spaceshipConstructionButton.interactable = false;
            leftArrow.interactable = false;
            rightArrow.interactable = false;
        }
    }

    /// <summary>
    /// This is the buy commands for all of the available items
    /// </summary>

    void BuyMainStructure()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.rock >= 100000 && mif.metal >= 100000)
        {
            // Array keep track of progression of the main quest, each item represents each element
            buyStatusCheckValue[0] = 1;

            checkListMainStructureText.color = new Color(0f, 216f / 255f, 0f);
            mif.rock -= 100000;
            mif.metal -= 100000;
            // To prevent players buying twice
            spaceshipConstructionButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyMainFrame()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.metal >= 10000 && mif.energy >= 20000)
        {
            buyStatusCheckValue[1] = 1;
            checkListMainframeText.color = new Color(0f, 216f / 255f, 0f);
            mif.metal -= 10000;
            mif.energy -= 20000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }

    void BuyPowerCore()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.metal >= 20000 && mif.energy >= 100000)
        {
            buyStatusCheckValue[2] = 1;
            checkListPowerCoreText.color = new Color(0f, 216f / 255f, 0f);
            mif.metal -= 20000;
            mif.energy -= 100000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }

    void BuyLivingQuarters()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.rock >= 10000 && mif.metal >= 10000 && mif.energy >= 15000 && mif.food >= 30000)
        {
            buyStatusCheckValue[3] = 1;
            checkListLivingQuartersText.color = new Color(0f, 216f / 255f, 0f);
            mif.rock -= 10000;
            mif.metal -= 10000;
            mif.energy -= 15000;
            mif.food -= 30000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }

    void BuyCafeteria()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.metal >= 10000 && mif.energy >= 10000 && mif.food >= 2000000)
        {
            buyStatusCheckValue[4] = 1;
            checkListCafeteriaText.color = new Color(0f, 216f / 255f, 0f);
            mif.metal -= 10000;
            mif.energy -= 15000;
            mif.food -= 2000000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }

    void BuyMedicalBay()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.metal >= 15000 && mif.energy >= 20000 && mif.food >= 20000)
        {
            buyStatusCheckValue[5] = 1;
            checkListMedicalBayText.color = new Color(0f, 216f / 255f, 0f);
            mif.metal -= 15000;
            mif.energy -= 20000;
            mif.food -= 20000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }

    void BuyScienceLabs()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.rock >= 15000 && mif.metal >= 25000 && mif.energy >= 15000 && mif.food >= 10000)
        {
            buyStatusCheckValue[6] = 1;
            checkListScienceLabsText.color = new Color(0f, 216f / 255f, 0f);
            mif.rock -= 15000;
            mif.metal -= 25000;
            mif.energy -= 15000;
            mif.food -= 10000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }

    void BuySpaceCannons()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.rock >= 50000 && mif.metal >= 15000 && mif.energy >= 15000)
        {
            buyStatusCheckValue[7] = 1;
            checkListSpaceCannonsText.color = new Color(0f, 216f / 255f, 0f);
            mif.rock -= 50000;
            mif.metal -= 15000;
            mif.energy -= 15000;
            spaceshipConstructionButton.interactable = false;
            ObjectiveCompletionCheck();
        }
    }
}
