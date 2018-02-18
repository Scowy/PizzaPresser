using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class MarsController : MonoBehaviour
{
    public GameObject earthInterface;
    public GameObject resourcesUpgradesPanel;
    public GameObject questsPanel;
    public GameObject spaceTravelPanel;
    public GameObject statsPanel;

    public GameObject resourcesUpgradesInterfaceButton;
    public GameObject questsInterfaceButton;
    public GameObject spaceTravelInterfaceButton;
    public GameObject statsInterfaceButton;

    [Header("Experience and food variables")]
    public float experience;
    public Text experienceText;
    public float experiencePerSecond;
    public Text experiencePerSecondText;
    public int clickMultiplierCount;
    public float food;
    public Text foodText;
    public float foodPerSecond;
    public Text foodRequirementText;
    public float rock;
    public Text rockText;
    public float rockPerSecond;
    public float metal;
    public Text metalText;
    public float metalPerSecond;
    public float energy;
    public Text energyText;
    public float energyPerSecond;
    public Text moneyText;

    [Header("Martian mechanic variables")]
    public Text martianHuntText;
    public Text martianCountText;
    public float huntCount;
    public float huntTime;
    public int martiansFoundValue;

    [Header("Building variables")]
    public int trainingCampCount;
    public int trainingCampBaseCost;
    private float trainingCampTotalCost;
    public Text trainingCampCountText;
    public Text trainingCampCostText;
    public GameObject trainingCampButton;

    public int martianFarmCount;
    public int martianFarmBaseCost;
    private float martianFarmTotalCost;
    public Text martianFarmCountText;
    public Text martianFarmCostText;
    public GameObject martianFarmButton;

    public int martianMineCount;
    public int martianMineBaseCost;
    private float martianMineTotalCost;
    public Text martianMineCountText;
    public Text martianMineCostText;
    public GameObject martianMineButton;

    public int martianPowerPlantCount;
    public int martianPowerPlantBaseCost;
    private float martianPowerPlantTotalCost;
    public Text martianPowerPlantCountText;
    public Text martianPowerPlantCostText;
    public Text martianPowerPlantRockText;
    public GameObject martianPowerPlantButton;

    public int martianHospitalCount;
    public int martianHospitalBaseCost;
    private float martianHospitalTotalCost;
    public Text martianHospitalCountText;
    public Text martianHospitalCostText;
    public Text martianHospitalRockText;
    public GameObject martianHospitalButton;

    public int martianFactoryCount;
    public int martianFactoryBaseCost;
    private float martianFactoryTotalCost;
    public Text martianFactoryCountText;
    public Text martianFactoryCostText;
    public Text martianFactoryRockText;
    public GameObject martianFactoryButton;

    public int martianSatelliteCount;
    public int martianSatelliteBaseCost;
    private float martianSatelliteTotalCost;
    public Text martianSatelliteCountText;
    public Text martianSatelliteCostText;
    public Text martianSatelliteRockText;
    public Text martianSatelliteMetalText;
    public Text martianSatelliteEnergyText;
    public GameObject martianSatelliteButton;

    public int martianResearchFacilityCount;
    public int martianResearchFacilityBaseCost;
    private float martianResearchFacilityTotalCost;
    public Text martianResearchFacilityCountText;
    public Text martianResearchFacilityCostText;
    public Text martianResearchFacilityRockText;
    public Text martianResearchFacilityMetalText;
    public Text martianResearchFacilityEnergyText;
    public GameObject martianResearchFacilityButton;
    public GameObject martianUpgradePanel;
    public Slider researchSlider;
    public Text researchPointsText;
    public Image sliderFill;
    private int researchPoints;
    private int researchMaxPoints;
    private float researchUpdateTime;
    public int[] buildlingLevel = { 1, 1, 1, 1, 1, 1, 1 }; 
    public Button trainingCampUpgradeButton;
    public Text trainingCampUpgradeCountText;
    public Button farmUpgradeButton;
    public Text farmUpgradeCountText;
    public Button mineUpgradeButton;
    public Text mineUpgradeCountText;
    public Button powerStationUpgradeButton;
    public Text powerStationUpgradeCountText;
    public Button hostpitalUpgradeButton;
    public Text hospitalUpgradeCountText;
    public Button factoryUpgradeButton;
    public Text factoryUpgradeCountText;
    public Button satelliteUpgradeButton;
    public Text satelliteUpgradeCountText;

    [Header("Martian variables")]
    public int martianCount;

    public int martianHunterCount;
    public int martianHunterBaseCost;
    private float martianHunterTotalCost;
    public Text martianHunterCountText;
    public Text martianHunterCostText;
    public GameObject martianHunterButton;

    public int martianPeonCount;
    public int martianPeonBaseCost;
    public float martianPeonTotalCost;
    public Text martianPeonCountText;
    public Text martianPeonCostText;
    public GameObject martianPeonButton;

    public int martianBuilderCount;
    public int martianBuilderBaseCost;
    public float martianBuilderTotalCost;
    public Text martianBuilderCountText;
    public Text martianBuilderCostText;
    public GameObject martianBuilderButton;

    public int martianTaskMasterCount;
    public int martianTaskMasterBaseCost;
    public float martianTaskMasterTotalCost;
    public Text martianTaskMasterCountText;
    public Text martianTaskMasterCostText;
    public GameObject martianTaskMasterButton;

    public int martianEngineerCount;
    public int martianEngineerBaseCost;
    public float martianEngineerTotalCost;
    public Text martianEngineerCountText;
    public Text martianEngineerCostText;
    public GameObject martianEngineerButton;

    public int martianDoctorCount;
    public int martianDoctorBaseCost;
    public float martianDoctorTotalCost;
    public Text martianDoctorCountText;
    public Text martianDoctorCostText;
    public GameObject martianDoctorButton;

    public int martianScientistCount;
    public int martianScientistBaseCost;
    public float martianScientistTotalCost;
    public Text martianScientistCountText;
    public Text martianScientistCostText;
    public GameObject martianScientistButton;

    public int martianSoldierCount;
    public int martianSoldierBaseCost;
    public float martianSoldierTotalCost;
    public Text martianSoldierCountText;
    public Text martianSoldierCostText;
    public GameObject martianSoldierButton;

    public int martianPilotCount;
    public int martianPilotBaseCost;
    public float martianPilotTotalCost;
    public Text martianPilotCountText;
    public Text martianPilotCostText;
    public GameObject martianPilotButton;

    public int foodShipmentCost;
    public Text foodShipmentCostText;
    public GameObject foodShipmentButton;

    public int foodBaitCost;
    public Text foodBaitCostText;
    public GameObject foodBaitButton;
    public GameObject foodBaitStartText;

    [Header("Spaceship Components")]
    public Button spaceshipConstructionButton;
    public Button spaceshipCrewButton;

    [Header("Stat variables")]
    public float experienceStatCounter;
    public float foodStatCounter;

    public int martianStatCounter;
    public int martianHunterCounter;
    public int martianPeonCounter;
    public int martianBuilderCounter;
    public int martianTaskMasterCounter;
    public int martianEngineerCounter;
    public int martianDoctorCounter;
    public int martianScientistCounter;
    public int martianSoldierCounter;
    public int martianPilotCounter;

    void Start ()
    {
        huntCount = 1;
        researchUpdateTime = 1;
        researchMaxPoints = 10;

        UpdateExperiencePerSecond();
        UpdateHuntTime();
        UpdateTrainingCamp();
        UpdateMartianFarm();
        UpdateMartianMine();
        UpdateMartianFactory();
        UpdateMartianHospital();
        UpdateMartianPowerPlant();
        UpdateMartianSatellite();
        UpdateMartianResearchFacility();

        UpdateMartianHunter();
        UpdateMartianPeon();
        UpdateMartianBuilder();
        UpdateMartianTaskMaster();
        UpdateMartianEngineer();
        UpdateMartianDoctor();
        UpdateMartianScientist();
        UpdateMartianSoldier();
        UpdateMartianPilot();

        SetExperiencePerSecondText();
        SetMartianCountText();
        SetMartianHunterText();

        SetTrainingCampText();
        SetMartianFarmText();
        SetMartianMineText();
        SetMartianFactoryText();
        SetMartianHospitalText();
        SetMartianPowerPlantText();
        SetMartianSatelliteText();
        SetMartianResearchFactilityText();
        SetUpgradeText();

        SetMartianPeonText();
        SetMartianBuilderText();
        SetMartianTaskMasterText();
        SetMartianEngineerText();
        SetMartianDoctorText();
        SetMartianScientistText();
        SetMartianSoldierText();
        SetMartianPilotText();
	}
	
	void Update ()
    {
        /// <summary>
        /// Core components of the level
        /// </summary>

        huntCount -= Time.deltaTime;
        researchUpdateTime -= Time.deltaTime;
        SetHuntText();

        if (huntCount <= 0)
        {
            martiansFoundValue = Mathf.RoundToInt(Random.Range(1, 2) * martianHunterCount * (1 + 0.05f * martianSatelliteCount) * (0.8f + 0.2f * buildlingLevel[6]));
            martianCount += martiansFoundValue;
            martianStatCounter += martiansFoundValue;
            huntCount = huntTime;
            SetHuntText();
            SetMartianCountText();
        }

        if (researchUpdateTime <= 0)
        {
            if (martianResearchFacilityCount >= 1)
            {
                if (researchPoints < researchMaxPoints)
                {
                    researchPoints += 1 * martianResearchFacilityCount;
                    ChangeSliderValue();
                }

                if (researchPoints > researchMaxPoints)
                {
                    researchPoints = researchMaxPoints;
                    ChangeSliderValue();
                }
            }
            researchUpdateTime = 1;
        }

        experience += experiencePerSecond * Time.deltaTime;
        food += foodPerSecond * Time.deltaTime;
        rock += rockPerSecond * Time.deltaTime;
        metal += metalPerSecond * Time.deltaTime;
        energy += energyPerSecond * Time.deltaTime;

        SetExperienceText();
        SetFoodText();
        SetRockText();
        SetMetalText();
        SetEnergyText();
        SetMoneyText();

        // This controls the colour for the martian food 

        if (food >= 500)
        {
            foodRequirementText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            foodRequirementText.color = Color.red;

        // This controls the colour of all the cost text of the buildings

        EarthController eif = earthInterface.GetComponent<EarthController>();

        if (eif.money >= 5000)
        {
            trainingCampCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            trainingCampCostText.color = Color.red;

        if (eif.money >= 5000)
        {
            martianFarmCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianFarmCostText.color = Color.red;

        if (eif.money >= 5000)
        {
            martianMineCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianMineCostText.color = Color.red;

        if (eif.money >= 50000)
        {
            martianPowerPlantCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianPowerPlantCostText.color = Color.red;

        if (eif.money >= 50000)
        {
            martianFactoryCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianFactoryCostText.color = Color.red;

        if (eif.money >= 50000)
        {
            martianHospitalCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianHospitalCostText.color = Color.red;

        if (eif.money >= 500000)
        {
            martianSatelliteCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianSatelliteCostText.color = Color.red;

        if (eif.money >= 500000)
        {
            martianResearchFacilityCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            martianResearchFacilityCostText.color = Color.red;
    }

    public void MartianPizzaClick()
    {
        experience += 1; //* Mathf.Pow(2, clickMultiplierCount);
        experienceStatCounter += 1;
        SetExperienceText();
    }

    /// <summary>
    /// Setting Text functions for core components
    /// </summary>

    public void SetExperienceText()
    {
        experienceText.text = "XP: " + experience.ToString("f0");
    }

    public void SetExperiencePerSecondText()
    {
        experiencePerSecondText.text = "XP per second: " + experiencePerSecond.ToString("f0");
    }

    public void SetHuntText()
    {
        martianHuntText.text = "Next hunt: " + huntCount.ToString("f0");
    }

    public void SetMartianCountText()
    {
        martianCountText.text = martianCount.ToString("f0");
    }

    public void SetMartianHunterText()
    {
        martianHunterCountText.text = martianHunterCount.ToString("f0");
        martianHunterCostText.text = martianHunterTotalCost.ToString("f0") + " XP";
    }

    public void SetFoodText()
    {
        foodText.text = "Food: " + food.ToString("f0");
    }

    public void SetRockText()
    {
        rockText.text = "Rock: " + rock.ToString("f0");
    }

    public void SetMetalText()
    {
        metalText.text = "Metal: " + metal.ToString("f0");
    }

    public void SetEnergyText()
    {
        energyText.text = "Energy: " + energy.ToString("f0");
    }

    public void SetMoneyText()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        moneyText.text = "Money: £" + eif.money.ToString("f0");
    }

    /// <summary>
    /// Setting Text functions for martian buildings
    /// </summary>

    public void SetTrainingCampText()
    {
        trainingCampCountText.text = trainingCampCount.ToString("f0");
        trainingCampCostText.text = "£" + trainingCampTotalCost.ToString("f0");
    }

    public void SetMartianFarmText()
    {
        martianFarmCountText.text = martianFarmCount.ToString("f0");
        martianFarmCostText.text = "£" + martianFarmTotalCost.ToString("f0");
    }

    public void SetMartianMineText()
    {
        martianMineCountText.text = martianMineCount.ToString("f0");
        martianMineCostText.text = "£" + martianMineTotalCost.ToString("f0");
    }

    public void SetMartianFactoryText()
    {
        martianFactoryCountText.text = martianFactoryCount.ToString("f0");
        martianFactoryCostText.text = "£" + martianFactoryTotalCost.ToString("f0");
        martianFactoryRockText.text = "500";
    }

    public void SetMartianPowerPlantText()
    {
        martianPowerPlantCountText.text = martianPowerPlantCount.ToString("f0");
        martianPowerPlantCostText.text = "£" + martianPowerPlantTotalCost.ToString("f0");
        martianPowerPlantRockText.text = "500";
    }

    public void SetMartianHospitalText()
    {
        martianHospitalCountText.text = martianHospitalCount.ToString("f0");
        martianHospitalCostText.text = "£" + martianHospitalTotalCost.ToString("f0");
        martianHospitalRockText.text = "500";
    }

    public void SetMartianSatelliteText()
    {
        martianSatelliteCountText.text = martianSatelliteCount.ToString("f0");
        martianSatelliteCostText.text = "£" + martianSatelliteTotalCost.ToString("f0");
        martianSatelliteRockText.text = "800";
        martianSatelliteMetalText.text = "800";
        martianSatelliteEnergyText.text = "500";
    }

    public void SetMartianResearchFactilityText()
    {
        martianResearchFacilityCountText.text = martianResearchFacilityCount.ToString("f0");
        martianResearchFacilityCostText.text = "£" + martianResearchFacilityTotalCost.ToString("f0");
        martianResearchFacilityRockText.text = "2000";
        martianResearchFacilityMetalText.text = "2000";
        martianResearchFacilityEnergyText.text = "2000";
    }

    /// <summary>
    /// Setting Text functions for martians
    /// </summary>

    public void SetMartianPeonText()
    {
        martianPeonCountText.text = martianPeonCount.ToString("f0");
        martianPeonCostText.text = martianPeonTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianBuilderText()
    {
        martianBuilderCountText.text = martianBuilderCount.ToString("f0");
        martianBuilderCostText.text = martianBuilderTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianTaskMasterText()
    {
        martianTaskMasterCountText.text = martianTaskMasterCount.ToString("f0");
        martianTaskMasterCostText.text = martianTaskMasterTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianEngineerText()
    {
        martianEngineerCountText.text = martianEngineerCount.ToString("f0");
        martianEngineerCostText.text = martianEngineerTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianDoctorText()
    {
        martianDoctorCountText.text = martianDoctorCount.ToString("f0");
        martianDoctorCostText.text = martianDoctorTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianScientistText()
    {
        martianScientistCountText.text = martianScientistCount.ToString("f0");
        martianScientistCostText.text = martianScientistTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianSoldierText()
    {
        martianSoldierCountText.text = martianSoldierCount.ToString("f0");
        martianSoldierCostText.text = martianSoldierTotalCost.ToString("f0") + " XP";
    }

    public void SetMartianPilotText()
    {
        martianPilotCountText.text = martianPilotCount.ToString("f0");
        martianPilotCostText.text = martianPilotTotalCost.ToString("f0") + " XP";
    }

    /// <summary>
    /// Setting text functions for shipments
    /// </summary>

    public void SetFoodShipmentText()
    {
        foodShipmentCostText.text = foodShipmentCost.ToString("f0");
    }

    public void SetFoodBaitText()
    {
        foodBaitCostText.text = foodBaitCost.ToString("f0");
    }

    /// <summary>
    /// Update value functions for buildings
    /// </summary>

    public void UpdateExperiencePerSecond()
    {
        if (martianFactoryCount >= 1)
        {
            experiencePerSecond = (1 * martianHunterCount + 3 * trainingCampCount) * (0.8f + 0.2f * (buildlingLevel[0])) * Mathf.Pow(1.15f, martianFactoryCount * (0.8f + 0.2f * (buildlingLevel[4])));
        }
        else
        {
            experiencePerSecond = (1 * martianHunterCount + 3 * trainingCampCount) * (0.8f + 0.2f * (buildlingLevel[0]));
        }
    }

    public void UpdateMartianHunter()
    {
        martianHunterTotalCost = 25 + 10 * martianHunterCount * Mathf.Pow(1.05f, martianHunterCount);
    }

    public void UpdateFoodPerSecond()
    {
        if (martianFactoryCount >= 1)
        {
            foodPerSecond = (2 * martianFarmCount) * Mathf.Pow(1.15f, martianFactoryCount * (0.8f + 0.2f * (buildlingLevel[4]))) * (0.8f + 0.2f * (buildlingLevel[1]));
        }
        else
        {
            foodPerSecond = (2 * martianFarmCount) * (0.8f + 0.2f * (buildlingLevel[1]));
        }
    }

    public void UpdateRockPerSecond()
    {


        if (martianFactoryCount >= 1)
        {
            rockPerSecond = (2 * martianMineCount) * Mathf.Pow(1.15f, martianFactoryCount * (0.8f + 0.2f * (buildlingLevel[4]))) * (0.8f + 0.2f * (buildlingLevel[2]));
        }
        else
        {
            rockPerSecond = 2 * martianMineCount * (0.8f + 0.2f * (buildlingLevel[2]));
        }
    }

    public void UpdateMetalPerSecond()
    {
        if (martianFactoryCount >= 1)
        {
            metalPerSecond = martianMineCount * Mathf.Pow(1.15f, martianFactoryCount * (0.8f + 0.2f * (buildlingLevel[4]))) * (0.8f + + 0.2f * (buildlingLevel[2]));
        }
        else
        {
            metalPerSecond = 1 * martianMineCount * (0.8f + 0.2f * (buildlingLevel[2]));
        }
    }

    public void UpdateEnergyPerSecond()
    {
        if (martianFactoryCount >= 1)
        {
            energyPerSecond = (2 * martianPowerPlantCount) * Mathf.Pow(1.15f, martianFactoryCount * (0.8f + 0.2f * (buildlingLevel[4]))) * (0.8f + 0.2f * (buildlingLevel[2]));
        }
        else
        {
            energyPerSecond = 2 * martianPowerPlantCount * (0.8f + 0.2f * (buildlingLevel[3]));
        }
    }

    public void UpdateHuntTime()
    {
        huntTime = 60f - 0.2f * martianSatelliteCount * (1 + 0.2f * buildlingLevel[6]);
    }

    public void UpdateTrainingCamp()
    {
        trainingCampTotalCost = trainingCampBaseCost;
    }

    public void UpdateMartianFarm()
    {
        martianFarmTotalCost = martianFarmBaseCost;
    }

    public void UpdateMartianMine()
    {
        martianMineTotalCost = martianMineBaseCost;
    }

    public void UpdateMartianFactory()
    {
        martianFactoryTotalCost = martianFactoryBaseCost;
    }

    public void UpdateMartianPowerPlant()
    {
        martianPowerPlantTotalCost = martianPowerPlantBaseCost;
    }

    public void UpdateMartianHospital()
    {
        martianHospitalTotalCost = martianHospitalBaseCost;
    }

    public void UpdateMartianSatellite()
    {
        martianSatelliteTotalCost = martianSatelliteBaseCost;     
    }

    public void UpdateMartianResearchFacility()
    {
        martianResearchFacilityTotalCost = martianResearchFacilityBaseCost;
    }

    /// <summary>
    /// Update value functions for buildings
    /// </summary>

    public void UpdateMartianPeon()
    {
        martianPeonTotalCost = martianPeonBaseCost * Mathf.Pow(1.01f, martianPeonCounter);
    }

    public void UpdateMartianBuilder()
    {
        martianBuilderTotalCost = martianBuilderBaseCost * Mathf.Pow(1.02f, martianBuilderCounter);
    }

    public void UpdateMartianTaskMaster()
    {
        martianTaskMasterTotalCost = martianTaskMasterBaseCost * Mathf.Pow(1.02f, martianTaskMasterCounter);
    }

    public void UpdateMartianEngineer()
    {
        martianEngineerTotalCost = martianEngineerBaseCost * Mathf.Pow(1.02f, martianEngineerCounter);
    }

    public void UpdateMartianDoctor()
    {
        martianDoctorTotalCost = martianDoctorBaseCost * Mathf.Pow(1.02f, martianDoctorCounter);
    }

    public void UpdateMartianScientist()
    {
        martianScientistTotalCost = martianScientistBaseCost * Mathf.Pow(1.02f, martianScientistCounter);
    }

    public void UpdateMartianSoldier()
    {
        martianSoldierTotalCost = martianSoldierBaseCost * Mathf.Pow(1.02f, martianSoldierCounter);
    }

    public void UpdateMartianPilot()
    {
        martianPilotTotalCost = martianPilotBaseCost * Mathf.Pow(1.02f, martianPilotCounter);
    }

    ///<summary>
    /// Control of the interface panels
    /// </summary>

    public void ResourcesInterfaceActivate()
    {
        resourcesUpgradesPanel.SetActive(true);
        questsPanel.SetActive(false);
        spaceTravelPanel.SetActive(false);
        statsPanel.SetActive(false);

        resourcesUpgradesInterfaceButton.GetComponent<Image>().color = Color.green;
        questsInterfaceButton.GetComponent<Image>().color = Color.white;
        spaceTravelInterfaceButton.GetComponent<Image>().color = Color.white;
        statsInterfaceButton.GetComponent<Image>().color = Color.white;
    }

    public void QuestsInterfaceActivate()
    {
        resourcesUpgradesPanel.SetActive(false);
        questsPanel.SetActive(true);
        spaceTravelPanel.SetActive(false);
        statsPanel.SetActive(false);

        resourcesUpgradesInterfaceButton.GetComponent<Image>().color = Color.white;
        questsInterfaceButton.GetComponent<Image>().color = Color.green;
        spaceTravelInterfaceButton.GetComponent<Image>().color = Color.white;
        statsInterfaceButton.GetComponent<Image>().color = Color.white;
    }

    public void SpaceTravelInterfaceActivate()
    {
        resourcesUpgradesPanel.SetActive(false);
        questsPanel.SetActive(false);
        spaceTravelPanel.SetActive(true);
        statsPanel.SetActive(false);

        resourcesUpgradesInterfaceButton.GetComponent<Image>().color = Color.white;
        questsInterfaceButton.GetComponent<Image>().color = Color.white;
        spaceTravelInterfaceButton.GetComponent<Image>().color = Color.green;
        statsInterfaceButton.GetComponent<Image>().color = Color.white;
    }

    public void StatsInterfaceActivate()
    {
        resourcesUpgradesPanel.SetActive(false);
        questsPanel.SetActive(false);
        spaceTravelPanel.SetActive(false);
        statsPanel.SetActive(true);

        resourcesUpgradesInterfaceButton.GetComponent<Image>().color = Color.white;
        questsInterfaceButton.GetComponent<Image>().color = Color.white;
        spaceTravelInterfaceButton.GetComponent<Image>().color = Color.white;
        statsInterfaceButton.GetComponent<Image>().color = Color.green;
    }

    /// <summary>
    /// Buy functions for items
    /// </summary>

    public void BuyTrainingCamp()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 5000 && martianPeonCount >= 5)
        {
            trainingCampCount += 1;
            eif.money -= 5000;
            martianPeonCount -= 5;

            if (trainingCampCount == 1)
            {
                martianTaskMasterButton.SetActive(true);
                martianBuilderButton.SetActive(true);
                martianFarmButton.SetActive(true);
                martianMineButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 5 * (1 + martianHospitalCount * 0.1f) + 1);
                
                if (martianRestoreChance >= 5)
                {
                    martianRestoreChance = 5;
                }
                martianPeonCount += martianRestoreChance;
            }


            UpdateExperiencePerSecond();
            UpdateTrainingCamp();

            SetExperiencePerSecondText();
            SetTrainingCampText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianTaskMasterText();
        }
    }

    public void BuyMartianFarm()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 5000 && martianTaskMasterCount >= 1 && martianPeonCount >= 8)
        {
            martianFarmCount += 1;
            eif.money -= 5000;
            martianPeonCount -= 8;
            martianTaskMasterCount -= 1;

            if (trainingCampCount >= 1 && martianFarmCount >= 1 && martianMineCount >= 1)
            {
                martianFactoryButton.SetActive(true);
                martianPowerPlantButton.SetActive(true);
                martianHospitalButton.SetActive(true);
                martianEngineerButton.SetActive(true);
                martianDoctorButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 8 * (1 + martianHospitalCount * 0.1f) + 1);

                if (martianRestoreChance >= 8)
                {
                    martianPeonCount += 8;
                    martianRestoreChance -= 8;

                    if (martianRestoreChance >= 1)
                    {
                        martianTaskMasterCount += 1;
                    }
                }
                else
                {
                    martianPeonCount += martianRestoreChance;
                }

            }

            UpdateFoodPerSecond();
            UpdateMartianFarm();

            SetFoodText();
            SetMartianFarmText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianBuilderText();
            SetMartianTaskMasterText();
        }
    }

    public void BuyMartianMine()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 5000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 5)
        {
            martianMineCount += 1;
            eif.money -= 5000;
            martianBuilderCount -= 5;
            martianTaskMasterCount -= 1;

            if (trainingCampCount >= 1 && martianFarmCount >= 1 && martianMineCount >= 1)
            {
                martianFactoryButton.SetActive(true);
                martianPowerPlantButton.SetActive(true);
                martianHospitalButton.SetActive(true);
                martianEngineerButton.SetActive(true);
                martianDoctorButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 4 * (1 + martianHospitalCount * 0.1f) + 1);


                if (martianRestoreChance >= 5)
                {
                    martianBuilderCount += 5;
                    martianRestoreChance -= 5;

                        if (martianRestoreChance >= 1)
                        {
                            martianTaskMasterCount += 1;
                        }
                }
                else
                {
                    martianBuilderCount += martianRestoreChance;
                }
            }

            UpdateRockPerSecond();
            UpdateMetalPerSecond();
            UpdateMartianMine();

            SetRockText();
            SetMetalText();
            SetMartianMineText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianBuilderText();
            SetMartianTaskMasterText();
        }
    }

    public void BuyMartianFactory()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 50000 && martianTaskMasterCount >= 1 &&  martianBuilderCount >= 3 && martianEngineerCount >= 3 &&  martianPeonCount >= 5 && rock >= 500)
        {
            martianFactoryCount += 1;
            eif.money -= 50000;
            rock -= 500;
            martianPeonCount -= 5;
            martianEngineerCount -= 3;
            martianBuilderCount -= 3;
            martianTaskMasterCount -= 1;

            if (martianFactoryCount >= 1 && martianPowerPlantCount >= 1 && martianHospitalCount >= 1)
            {
                martianSatelliteButton.SetActive(true);
                martianResearchFacilityButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 12 * (0.9f + martianHospitalCount * 0.1f) + 1);

                if (martianRestoreChance >= 5)
                {
                    martianPeonCount += 5;
                    martianRestoreChance -= 5;

                    if (martianRestoreChance >= 3)
                    {
                        martianBuilderCount += 3;
                        martianRestoreChance -= 3;

                        if (martianRestoreChance >= 3)
                        {
                            martianEngineerCount += 3;
                            martianRestoreChance -= 3;

                            if (martianRestoreChance >= 1)
                            {
                                martianTaskMasterCount += 1;
                            }
                            else
                            {
                                martianTaskMasterCount += martianRestoreChance;
                            }
                        }
                        else
                        {
                            martianEngineerCount += martianRestoreChance;
                        }
                    }
                    else
                    {
                        martianBuilderCount += martianRestoreChance;
                    }
                }
                else
                {
                    martianPeonCount += martianRestoreChance;
                }
            }

            UpdateMartianFactory();
            UpdateExperiencePerSecond();
            SetExperiencePerSecondText();
            UpdateFoodPerSecond();
            UpdateRockPerSecond();
            UpdateMetalPerSecond();
            UpdateEnergyPerSecond();

            SetMartianFactoryText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianEngineerText();
            SetMartianBuilderText();
            SetMartianTaskMasterText();
        }
    }

    public void BuyMartianPowerPlant()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 50000 && martianTaskMasterCount >= 1 && martianEngineerCount >= 3 && martianBuilderCount >= 3 && martianPeonCount >= 5 && rock >= 500)
        {
            martianPowerPlantCount += 1;
            eif.money -= 50000;
            rock -= 500;
            martianPeonCount -= 5;
            martianBuilderCount -= 3;
            martianEngineerCount -= 3;
            martianTaskMasterCount -= 1;

            if (martianFactoryCount >= 1 && martianPowerPlantCount >= 1 && martianHospitalCount >= 1)
            {
                martianSatelliteButton.SetActive(true);
                martianResearchFacilityButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 12 * (0.9f + martianHospitalCount * 0.1f) + 1);

                if (martianRestoreChance >= 5)
                {
                    martianPeonCount += 5;
                    martianRestoreChance -= 5;

                    if (martianRestoreChance >= 3)
                    {
                        martianBuilderCount += 3;
                        martianRestoreChance -= 3;

                        if (martianRestoreChance >= 3)
                        {
                            martianEngineerCount += 3;
                            martianRestoreChance -= 3;

                            if (martianRestoreChance >= 1)
                            {
                                martianTaskMasterCount += 1;
                            }
                        }
                        else
                        {
                            martianEngineerCount += martianRestoreChance;
                        }
                    }
                    else
                    {
                        martianBuilderCount += martianRestoreChance;
                    }
                }
                else
                {
                    martianPeonCount += martianRestoreChance;
                }
            }

            UpdateEnergyPerSecond();
            UpdateMartianPowerPlant();

            SetMartianPowerPlantText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianEngineerText();
            SetMartianBuilderText();
            SetMartianTaskMasterText();
        }
    }

    public void BuyMartianHospital()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 50000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 3 && martianDoctorCount >= 3 &&  martianPeonCount >= 5 && rock >= 500)
        {
            martianHospitalCount += 1;
            eif.money -= 50000;
            rock -= 500;
            martianPeonCount -= 5;
            martianDoctorCount -= 3;
            martianBuilderCount -= 3;
            martianTaskMasterCount -= 1;

            if (martianFactoryCount >= 1 && martianPowerPlantCount >= 1 && martianHospitalCount >= 1)
            {
                martianSatelliteButton.SetActive(true);
                martianResearchFacilityButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 12 * (0.9f + martianHospitalCount * 0.1f) + 1);

                if (martianRestoreChance >= 5)
                {
                    martianPeonCount += 5;
                    martianRestoreChance -= 5;

                    if (martianRestoreChance >= 3)
                    {
                        martianBuilderCount += 3;
                        martianRestoreChance -= 3;

                        if (martianRestoreChance >= 3)
                        {
                            martianDoctorCount += 3;
                            martianRestoreChance -= 3;

                            if (martianRestoreChance >= 1)
                            {
                                martianTaskMasterCount += 1;
                            }
                            else
                            {
                                martianTaskMasterCount += martianRestoreChance;
                            }
                        }
                        else
                        {
                            martianEngineerCount += martianRestoreChance;
                        }
                    }
                    else
                    {
                        martianBuilderCount += martianRestoreChance;
                    }
                }
                else
                {
                    martianPeonCount += martianRestoreChance;
                }
            }

            UpdateMartianHospital();

            SetMartianHospitalText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianBuilderText();
            SetMartianDoctorText();
            SetMartianTaskMasterText();
        }
    }

    public void BuyMartianSatellite()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 500000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 3 && martianEngineerCount >= 3 && martianScientistCount >= 3 && martianPeonCount >= 5 && rock >= 800 && metal >= 800 && energy >= 500)
        {
            martianSatelliteCount += 1;
            eif.money -= 50000;
            rock -= 800;
            metal -= 800;
            energy -= 500;
            martianPeonCount -= 5;
            martianScientistCount -= 3;
            martianEngineerCount -= 3;
            martianBuilderCount -= 3;
            martianTaskMasterCount -= 1;

            if (martianSatelliteCount >= 1 && martianResearchFacilityCount >= 1)
            {
                martianSoldierButton.SetActive(true);
                martianPilotButton.SetActive(true);
                spaceshipConstructionButton.interactable = true;
                spaceshipCrewButton.interactable = true;
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 18 * (0.9f + martianHospitalCount * 0.1f) + 1);

                if (martianRestoreChance >= 5)
                {
                    martianPeonCount += 5;
                    martianRestoreChance -= 5;

                    if (martianRestoreChance >= 3)
                    {
                        martianBuilderCount += 3;
                        martianRestoreChance -= 3;

                        if (martianRestoreChance >= 3)
                        {
                            martianEngineerCount += 3;
                            martianRestoreChance -= 3;

                            if (martianRestoreChance >= 3)
                            {
                                martianScientistCount += 3;
                                martianRestoreChance -= 3;

                                if (martianRestoreChance >= 1)
                                {
                                    martianTaskMasterCount += 1;
                                }
                            }
                            else
                            {
                                martianScientistCount += martianRestoreChance;
                            }
                        }
                        else
                        {
                            martianEngineerCount += martianRestoreChance;
                        }
                    }
                    else
                    {
                        martianBuilderCount += martianRestoreChance;
                    }
                }
                else
                {
                    martianPeonCount += martianRestoreChance;
                }
            }

            UpdateMartianSatellite();
            UpdateHuntTime();

            SetMartianSatelliteText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianEngineerText();
            SetMartianScientistText();
            SetMartianBuilderText();
            SetMartianDoctorText();
            SetMartianTaskMasterText();

        }
    }

    public void BuyMartianResearchFacility()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 500000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 10 && martianEngineerCount >= 10 && martianScientistCount >= 10 && martianPeonCount >= 10 && martianDoctorCount >= 10 && rock >= 2000 && metal >= 2000 && energy >= 2000)
        {
            martianResearchFacilityCount += 1;
            martianUpgradePanel.SetActive(true);
            eif.money -= 50000;
            rock -= 2000;
            metal -= 2000;
            energy -= 2000;
            martianPeonCount -= 10;
            martianScientistCount -= 10;
            martianEngineerCount -= 10;
            martianBuilderCount -= 10;
            martianDoctorCount -= 10;
            martianTaskMasterCount -= 1;

            if (martianSatelliteCount >= 1 && martianResearchFacilityCount >= 1)
            {
                martianSoldierButton.SetActive(true);
                martianPilotButton.SetActive(true);
                spaceshipConstructionButton.interactable = true;
                spaceshipCrewButton.interactable = true;
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt(Random.value * 0.05f * 51 * (0.9f + martianHospitalCount * 0.1f) + 1);

                if (martianRestoreChance >= 10)
                {
                    martianPeonCount += 10;
                    martianRestoreChance -= 10;

                    if (martianRestoreChance >= 10)
                    {
                        martianBuilderCount += 10;
                        martianRestoreChance -= 10;

                        if (martianRestoreChance >= 10)
                        {
                            martianEngineerCount += 10;
                            martianRestoreChance -= 10;

                            if (martianRestoreChance >= 10)
                            {
                                martianScientistCount += 10;
                                martianRestoreChance -= 10;

                                if (martianRestoreChance >= 10)
                                {
                                    martianDoctorCount += 10;
                                    martianRestoreChance -= 10;

                                    if (martianRestoreChance >= 1)
                                    {
                                        martianTaskMasterCount += 1;
                                    }
                                }
                                else
                                {
                                    martianDoctorCount += martianRestoreChance;
                                }
                            }
                            else
                            {
                                martianScientistCount += martianRestoreChance;
                            }
                        }
                        else
                        {
                            martianEngineerCount += martianRestoreChance;
                        }
                    }
                    else
                    {
                        martianBuilderCount += martianRestoreChance;
                    }
                }
                else
                {
                    martianPeonCount += martianRestoreChance;
                }
            }

            UpdateMartianResearchFacility();

            SetMartianResearchFactilityText();
            SetMoneyText();
            SetMartianPeonText();
            SetMartianEngineerText();
            SetMartianScientistText();
            SetMartianBuilderText();
            SetMartianDoctorText();
            SetMartianTaskMasterText();
        }
    }

    /// <summary>
    /// Buy functions for reagants
    /// </summary>

    public void BuyMartianPeon()
    {
       if(experience >= martianPeonTotalCost && food >= 500 && martianCount >= 1)
        {
            martianPeonCount += 1;
            martianPeonCounter += 1;
            experience -= martianPeonTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianPeon();

            SetMartianPeonText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianHunter()
    {
        if (experience >= martianHunterTotalCost && food >= 500 && martianCount >= 1)
        {
            martianHunterCount += 1;
            experiencePerSecond += 1;
            experience -= martianHunterTotalCost;
            food -= 500;
            martianCount -= 1;

            if (martianHunterCount == 1)
            {
                foodBaitStartText.SetActive(false);
            }

            UpdateMartianHunter();

            SetMartianHunterText();
            SetMartianCountText();
            SetExperiencePerSecondText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianBuilder()
    {
        if (experience >= martianBuilderTotalCost && food >= 500 && martianCount >= 1)
        {
            martianBuilderCount += 1;
            martianBuilderCounter += 1;
            experience -= martianBuilderTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianBuilder();

            SetMartianBuilderText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianTaskMaster()
    {
        if (experience >= martianTaskMasterTotalCost && food >= 500 && martianCount >= 1)
        {
            martianTaskMasterCount += 1;
            martianTaskMasterCounter += 1;
            experience -= martianTaskMasterTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianTaskMaster();

            SetMartianTaskMasterText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianEngineer()
    {
        if (experience >= martianEngineerTotalCost && food >= 500 && martianCount >= 1)
        {
            martianEngineerCount += 1;
            martianEngineerCounter += 1;
            experience -= martianEngineerTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianEngineer();

            SetMartianEngineerText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianDoctor()
    {
        if (experience >= martianDoctorTotalCost && food >= 500 && martianCount >= 1)
        {
            martianDoctorCount += 1;
            martianDoctorCounter += 1;
            experience -= martianDoctorTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianDoctor();

            SetMartianDoctorText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianScientist()
    {
        if (experience >= martianScientistTotalCost && food >= 500 && martianCount >= 1)
        {
            martianScientistCount += 1;
            martianScientistCounter += 1;
            experience -= martianScientistTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianScientist();

            SetMartianScientistText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianSoldier()
    {
        if (experience >= martianSoldierTotalCost && food >= 500 && martianCount >= 1)
        {
            martianSoldierCount += 1;
            martianSoldierCounter += 1;
            experience -= martianSoldierTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianSoldier();

            SetMartianSoldierText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianPilot()
    {
        if (experience >= martianPilotTotalCost && food >= 500 && martianCount >= 1)
        {
            martianPilotCount += 1;
            martianPilotCounter += 1;
            experience -= martianPilotTotalCost;
            food -= 500;
            martianCount -= 1;

            UpdateMartianPilot();

            SetMartianPilotText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    /// <summary>
    /// Shipment functions
    /// </summary>

    public void UseFoodBait()
    {
        if(food >= 250)
        {
            food -= 250;
            int baitValue = Random.Range(0, 100);

            if(baitValue >= 80)
            {
                martianCount += 1;
                martianStatCounter += 1;
            }

            SetMartianCountText();
        }
    }

    public void SendFoodShipment()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 200000)
        {
            food += 1000 * (1 + 0.05f * martianHospitalCount) * (0.8f + 0.2f * buildlingLevel[5]);
        }
    }

    /// <summary>
    /// Research and upgrade functions
    /// </summary>

    void ChangeSliderValue()
    {
        researchSlider.value = researchPoints;
        researchPointsText.text = researchPoints + " / " + researchMaxPoints;

        if (researchPoints == researchMaxPoints)
        {
            sliderFill.color = new Color(71f / 255f, 1f, 149f / 255f);
        }
    }

    void NextUpgradeLevel()
    {
        researchPoints = 0;
        researchMaxPoints = 2 * researchMaxPoints;
        researchSlider.maxValue = researchMaxPoints;
        ChangeSliderValue();
        sliderFill.color = new Color(0f, 195f / 255f, 34f / 255f);
    }

    public void SetUpgradeText()
    {
        trainingCampUpgradeCountText.text = "Training Camp: Rank " + buildlingLevel[0];
        farmUpgradeCountText.text = "Farm: Rank " + buildlingLevel[1];
        mineUpgradeCountText.text = "Mine: Rank " + buildlingLevel[2];
        powerStationUpgradeCountText.text = "Power Station: Rank " + buildlingLevel[3];
        hospitalUpgradeCountText.text = "Hostpital: Rank " + buildlingLevel[4];
        factoryUpgradeCountText.text = "Factory: Rank " + buildlingLevel[5];
        satelliteUpgradeCountText.text = "Satellite: Rank " + buildlingLevel[6];
    }

    public void UpgradeTrainingCamp()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[0] += 1;
            UpdateExperiencePerSecond();
            SetExperiencePerSecondText();
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }

    public void UpgradeFarm()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[1] += 1;
            UpdateFoodPerSecond();
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }

    public void UpgradeMine()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[2] += 1;
            UpdateRockPerSecond();
            UpdateMetalPerSecond();
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }

    public void UpgradePowerStation()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[3] += 1;
            UpdateEnergyPerSecond();
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }

    public void UpgradeHospital()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[4] += 1;
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }

    public void UpgradeFactory()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[5] += 1;
            UpdateExperiencePerSecond();
            SetExperiencePerSecondText();
            UpdateFoodPerSecond();
            UpdateRockPerSecond();
            UpdateMetalPerSecond();
            UpdateEnergyPerSecond();
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }

    public void UpgradeSatellite()
    {
        if (researchPoints == researchMaxPoints)
        {
            buildlingLevel[6] += 1;
            UpdateHuntTime();
            SetUpgradeText();
            NextUpgradeLevel();
        }
    }
}
