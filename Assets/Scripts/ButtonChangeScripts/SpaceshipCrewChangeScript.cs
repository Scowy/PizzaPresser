using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipCrewChangeScript : MonoBehaviour
{
    private int i;
    private int[] buyStatusCheckValue = { 0, 0, 0, 0, 0, 0, 0};
    private string buttonName;

    public GameObject marsInterface;

    public Button spaceshipCrewButton;
    public Text buttonText;
    public Button leftArrow;
    public Button rightArrow;
    public Text requirementText1;
    public Text requirementText2;
    public Text requirementText3;
    public Text requirementText4;
    public Text requirementText5;
    public Text requirementText6;

    public Text checkListPilotCrewText;
    public Text checkListEngineCrewText;
    public Text checkListExplorationSquardronText;
    public Text checkListWorkForceText;
    public Text checkListMedicalCrewText;
    public Text checkListResearchDivisionText;
    public Text checkListDefenceForceText;

    void Start()
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
        if (spaceshipCrewButton.interactable == false)
        {
            spaceshipCrewButton.interactable = true;
        }

        i += 1;

        // Stops i from exceeding the array size and cycles it back
        if (i >= 8)
        {
            i = 1;
        }

        // This removes bought items from being viewed
        while (buyStatusCheckValue[i - 1] == 1)
        {
            i += 1;

            if (i >= 8)
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
            i = 7;
        }

        while (buyStatusCheckValue[i - 1] == 1)
        {
            i -= 1;

            if (i <= 0)
            {
                i = 7;
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
            BuyPilotCrew();
        }
        if (i == 2)
        {
            BuyEngineCrew();
        }
        if (i == 3)
        {
            BuyExplorationSquadron();
        }
        if (i == 4)
        {
            BuyWorkForce();
        }
        if (i == 5)
        {
            BuyMedicalCrew();
        }
        if (i == 6)
        {
            BuyResearchDivision();
        }
        if (i == 7)
        {
            BuyDefenceForce();
        }
    }

    /// <summary>
    /// Changes all the text when switching between items
    /// </summary>

    void ButtonTextChange()
    {
        if (i == 1)
        {
            buttonName = "Pilot Crew";
            buttonText.text = buttonName;
            requirementText1.text = "1 Taskmaster";
            requirementText2.text = "30 Pilots";
            requirementText3.text = "10 Engineers";
            requirementText4.enabled = false;
            requirementText5.enabled = false;
            requirementText6.enabled = false;
        }
        if (i == 2)
        {
            buttonName = "Engine Crew";
            buttonText.text = buttonName;
            requirementText1.text = "1 Taskmaster";
            requirementText2.text = "100 Engineers";
            requirementText3.text = "150 Peons";
            requirementText4.enabled = false;
            requirementText5.enabled = false;
            requirementText6.enabled = false;
        }
        if (i == 3)
        {
            buttonName = "Exploration Squadron";
            buttonText.text = buttonName;
            requirementText1.text = "1 Taskmaster";
            requirementText2.text = "100 Soldiers";
            requirementText3.text = "20 Pilots";
            requirementText4.text = "50 Engineers";
            requirementText5.text = "20 Doctors";
            requirementText6.text = "200 Peons";
        }
        if (i == 4)
        {
            buttonName = "Work Force";
            buttonText.text = buttonName;
            requirementText1.text = "20 Taskmaster";
            requirementText2.text = "1500 Peons";
            requirementText3.enabled = false;
            requirementText4.enabled = false;
            requirementText5.enabled = false;
            requirementText6.enabled = false;
        }
        if (i == 5)
        {
            buttonName = "Medical Crew";
            buttonText.text = buttonName;
            requirementText1.text = "1 Taskmaster";
            requirementText2.text = "50 Doctors";
            requirementText3.text = "150 Peons";
            requirementText4.enabled = false;
            requirementText5.enabled = false;
            requirementText6.enabled = false;
        }
        if (i == 6)
        {
            buttonName = "Research Division";
            buttonText.text = buttonName;
            buttonText.text = buttonName;
            requirementText1.text = "1 Taskmaster";
            requirementText2.text = "100 Scientists";
            requirementText3.text = "100 Doctors";
            requirementText4.text = "100 Engineers";
            requirementText5.enabled = false;
            requirementText6.enabled = false;
        }
        if (i == 7)
        {
            buttonName = "Defence Force";
            buttonText.text = buttonName;
            requirementText1.text = "1 Taskmaster";
            requirementText2.text = "100 Soldiers";
            requirementText3.text = "100 Pilots";
            requirementText4.enabled = false;
            requirementText5.enabled = false;
            requirementText6.enabled = false;
        }
    }

    /// <summary>
    /// This ends the objective once the player has bought all the items, used after every item purchase
    /// </summary>

    void ObjectiveCompletionCheck()
    {
        if (buyStatusCheckValue[0] == 1 && buyStatusCheckValue[1] == 1 && buyStatusCheckValue[2] == 1 && buyStatusCheckValue[3] == 1 && buyStatusCheckValue[4] == 1 && buyStatusCheckValue[5] == 1 && buyStatusCheckValue[6] == 1 && buyStatusCheckValue[7] == 1)
        {
            spaceshipCrewButton.interactable = false;
            leftArrow.interactable = false;
            rightArrow.interactable = false;
        }
    }

    /// <summary>
    /// This is the buy commands for all of the available items
    /// </summary>

    void BuyPilotCrew()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 1 && mif.martianPilotCount >= 30 && mif.martianEngineerCount >= 10)
        {
            // Array keep track of progression of the main quest, each item represents each element
            buyStatusCheckValue[0] = 1;

            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 1;
            mif.martianPilotCount -= 30;
            mif.martianEngineerCount -= 10;
            // To prevent players buying twice
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyEngineCrew()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 1 && mif.martianEngineerCount >= 100 && mif.martianPeonCount >= 150)
        {
            buyStatusCheckValue[1] = 1;
            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 1;
            mif.martianPilotCount -= 30;
            mif.martianEngineerCount -= 10;
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyExplorationSquadron()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 1 && mif.martianEngineerCount >= 50 && mif.martianPeonCount >= 200 && mif.martianSoldierCount >= 100 && mif.martianPilotCount >= 20 && mif.martianDoctorCount >= 20)
        {
            buyStatusCheckValue[2] = 1;
            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 1;
            mif.martianPilotCount -= 20;
            mif.martianEngineerCount -= 50;
            mif.martianPeonCount -= 200;
            mif.martianSoldierCount -= 100;
            mif.martianDoctorCount -= 20;
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyWorkForce()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 20 && mif.martianPeonCount >= 1500)
        {
            buyStatusCheckValue[3] = 1;
            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 20;
            mif.martianPeonCount -= 1500;
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyMedicalCrew()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 1 && mif.martianDoctorCount >= 50 && mif.martianPeonCount >= 1500)
        {
            buyStatusCheckValue[4] = 1;
            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 1;
            mif.martianDoctorCount -= 50;
            mif.martianPeonCount -= 150;
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyResearchDivision()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 1 && mif.martianDoctorCount >= 100 && mif.martianScientistCount >= 100 && mif.martianEngineerCount >= 100)
        {
            buyStatusCheckValue[5] = 1;
            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 1;
            mif.martianDoctorCount -= 100;
            mif.martianScientistCount -= 100;
            mif.martianEngineerCount -= 100;
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }

    void BuyDefenceForce()
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();

        if (mif.martianTaskMasterCount >= 1 && mif.martianSoldierCount >= 100 && mif.martianPilotCount >= 100)
        {
            buyStatusCheckValue[6] = 1;
            checkListPilotCrewText.color = new Color(0f, 216f / 255f, 0f);
            mif.martianTaskMasterCount -= 1;
            mif.martianSoldierCount -= 100;
            mif.martianPilotCount -= 100;
            spaceshipCrewButton.interactable = false;

            ObjectiveCompletionCheck();
        }
    }
}
