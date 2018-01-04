using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class MarsController : MonoBehaviour
{
    [Header("Experience and food variables")]
    public float experience;
    public Text experienceText;
    public float experiencePerSecond;
    public Text experiencePerSecondText;
    public int clickMultiplierCount;
    public float food;
    public Text foodText;
    public float foodPerSecond;
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
    public GameObject martianPowerPlantButton;

    public int martianHospitalCount;
    public int martianHospitalBaseCost;
    private float martianHospitalTotalCost;
    public Text martianHospitalCountText;
    public Text martianHospitalCostText;
    public GameObject martianHospitalButton;

    public int martianFactoryCount;
    public int martianFactoryBaseCost;
    private float martianFactoryTotalCost;
    public Text martianFactoryCountText;
    public Text martianFactoryCostText;
    public GameObject martianFactoryButton;

    public int martianSatelliteCount;
    public int martianSatelliteBaseCost;
    private float martianSatelliteTotalCost;
    public Text martianSatelliteCountText;
    public Text martianSatelliteCostText;
    public GameObject martianSatelliteButton;

    public int martianResearchFacilityCount;
    public int martianResearchFacilityBaseCost;
    private float martianResearchFacilityTotalCost;
    public Text martianResearchFacilityCountText;
    public Text martianResearchFacilityCostText;
    public GameObject martianResearchFacilityButton;

    [Header("Spaceship variables")]
    public int martianSpaceCruiserCount;
    public int martianSpaceCruiserCost;
    public Text martianSpaceCruiserCostText;
    public GameObject martianSpaceCruiserButton;

    public int spaceShipMainFrameCount;
    public int spaceShipMainFrameCost;
    public Text spaceShipMainFrameCostText;
    public GameObject spaceShipMainFrameButton;

    public int spaceShipPowerCoreCount;
    public int spaceShipPowerCoreCost;
    public Text spaceShipPowerCoreCostText;
    public GameObject spaceShipPowerCoreButton;

    public int spaceShipCargoHoldCount;
    public int spaceShipCargoHoldCost;
    public Text spaceShipCargoHoldCostText;
    public GameObject spaceShipCargoHoldButton;

    public int spaceShipLivingQuartersCount;
    public int spaceShipLivingQuartersCost;
    public Text spaceShipLivingQuartersCostText;
    public GameObject spaceShipLivingQuartersButton;

    public int spaceShipDiningAreaCount;
    public int spaceShipDiningAreaCost;
    public Text spaceShipDiningAreaCostText;
    public GameObject spaceShipDiningAreaButton;

    public int spaceShipMedicalBayCount;
    public int spaceShipMedicalBayCost;
    public Text spaceShipMedicalBayCostText;
    public GameObject spaceShipMedicalBayButton;

    public int spaceShipLaboratoryCount;
    public int spaceShipLaboratoryCost;
    public Text spaceShipLaboratoryCostText;
    public GameObject spaceShipLaboratoryButton;

    public int spaceShipShieldGeneratorCount;
    public int spaceShipShieldGeneratorCost;
    public Text spaceShipShieldGeneratorCostText;
    public GameObject spaceShipShieldGeneratorButton;

    public int spaceShipMountedCannonsCount;
    public int spaceShipMountedCannonsCost;
    public Text spaceShipMountedCannonsCostText;
    public GameObject spaceShipMountedCannonsButton;

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
    public int martiannSoldierCost;
    public Text martianSoldierCountText;
    public GameObject martianSoldierButton;

    public int martianPilotCount;
    public int martianPilotCost;
    public Text martianPilotCountText;
    public GameObject martianPilotButton;

    public int foodShipmentCost;
    public Text foodShipmentCostText;
    public GameObject foodShipmentButton;

    public int foodBaitCost;
    public Text foodBaitCostText;
    public GameObject foodBaitButton;

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

        SetMartianPeonText();
        SetMartianBuilderText();
        SetMartianTaskMasterText();
        SetMartianEngineerText();
        SetMartianDoctorText();
        SetMartianScientistText();
	}
	
	void Update ()
    {
        /// <summary>
        /// Core components of the level
        /// </summary>

        huntCount -= Time.deltaTime;
        SetHuntText();

        if (huntCount <= 0)
        {
            martiansFoundValue = Random.Range(0, 3) * martianHunterCount;
            martianCount += martiansFoundValue;
            huntCount = huntTime;
            SetHuntText();
            SetMartianCountText();
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
    }

    public void MartianPizzaClick()
    {
        experience += 1; //* Mathf.Pow(2, clickMultiplierCount);
        experienceStatCounter += 1;
        SetExperienceText();
    }

    /// <summary>
    /// Planet changing commands
    /// </summary>

    public void LoadEarth()
    {
        Scene earth = SceneManager.GetSceneByName("Earth");

        if (earth.isLoaded == true)
        {
            SceneManager.SetActiveScene(earth);
        }
        else
        {
            SceneManager.LoadScene("Earth", LoadSceneMode.Additive);
        }
    }

    public void LoadMars()
    {
        Scene mars = SceneManager.GetSceneByName("Mars");
        if (mars.isLoaded == true)
        {
            SceneManager.SetActiveScene(mars);
        }
        else
        {
            SceneManager.LoadScene("Mars", LoadSceneMode.Additive);
        }
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
    }

    public void SetMartianPowerPlantText()
    {
        martianPowerPlantCountText.text = martianPowerPlantCount.ToString("f0");
        martianPowerPlantCostText.text = "£" + martianPowerPlantTotalCost.ToString("f0");
    }

    public void SetMartianHospitalText()
    {
        martianHospitalCountText.text = martianHospitalCount.ToString("f0");
        martianHospitalCostText.text = "£" + martianHospitalTotalCost.ToString("f0");
    }

    public void SetMartianSatelliteText()
    {
        martianSatelliteCountText.text = martianSatelliteCount.ToString("f0");
        martianSatelliteCostText.text = "£" + martianSatelliteTotalCost.ToString("f0");
    }

    public void SetMartianResearchFactilityText()
    {
        martianResearchFacilityCountText.text = martianResearchFacilityCount.ToString("f0");
        martianResearchFacilityCostText.text = "£" + martianResearchFacilityTotalCost.ToString("f0");
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
    }

    public void SetMartianPilotText()
    {
        martianPilotCountText.text = martianPilotCount.ToString("f0");
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
        experiencePerSecond = 0 + 1 * martianHunterCount + 3 * trainingCampCount;

        if (martianFactoryCount >= 1)
        {
            experiencePerSecond = (1 * martianHunterCount *  + 2 * trainingCampCount) * Mathf.Pow(1.05f, martianFactoryCount);
        }
    }

    public void UpdateMartianHunter()
    {
        martianHunterTotalCost = 25 + 25 * martianHunterCount * Mathf.Pow(1.05f, martianHunterCount);
    }

    public void UpdateFoodPerSecond()
    {
        foodPerSecond = 2 * martianFarmCount;

        if (martianFactoryCount >= 1)
        {
            experiencePerSecond = (5 * martianFarmCount) * Mathf.Pow(1.05f, martianFactoryCount);
        }
    }

    public void UpdateRockPerSecond()
    {
        rockPerSecond = 3 * martianMineCount;

        if (martianFactoryCount >= 1)
        {
            experiencePerSecond = (5 * martianMineCount) * Mathf.Pow(1.05f, martianFactoryCount);
        }
    }

    public void UpdateMetalPerSecond()
    {
        metalPerSecond = 1 * martianMineCount;

        if (martianFactoryCount >= 1)
        {
            experiencePerSecond = (2 * martianMineCount) * Mathf.Pow(1.05f, martianFactoryCount);
        }
    }

    public void UpdateEnergyPerSecond()
    {
        energyPerSecond = 2 * martianPowerPlantCount;

        if (martianFactoryCount >= 1)
        {
            experiencePerSecond = (5 * martianPowerPlantCount) * Mathf.Pow(1.05f, martianFactoryCount);
        }
    }

    public void UpdateHuntTime()
    {
        huntTime = 60f - 0.3f * martianSatelliteCount;
    }

    public void UpdateTrainingCamp()
    {
        trainingCampTotalCost = trainingCampBaseCost * Mathf.Pow(1.05f, trainingCampCount);
    }

    public void UpdateMartianFarm()
    {
        martianFarmTotalCost = martianFarmBaseCost * Mathf.Pow(1.05f, martianFarmCount);
    }

    public void UpdateMartianMine()
    {
        martianMineTotalCost = martianMineBaseCost * Mathf.Pow(1.05f, martianMineCount);
    }

    public void UpdateMartianFactory()
    {
        martianFactoryTotalCost = martianFactoryBaseCost * Mathf.Pow(1.05f, martianFactoryCount);
    }

    public void UpdateMartianPowerPlant()
    {
        martianPowerPlantTotalCost = martianPowerPlantBaseCost * Mathf.Pow(1.05f, martianPowerPlantCount);
    }

    public void UpdateMartianHospital()
    {
        martianHospitalTotalCost = martianHospitalBaseCost * Mathf.Pow(1.05f, martianHospitalCount);
    }

    public void UpdateMartianSatellite()
    {
        martianSatelliteTotalCost = martianSatelliteBaseCost * Mathf.Pow(1.05f, martianSatelliteCount);     
    }

    public void UpdateMartianResearchFacility()
    {
        martianResearchFacilityTotalCost = martianResearchFacilityBaseCost * Mathf.Pow(1.05f, martianResearchFacilityCount);
    }

    /// <summary>
    /// Update value functions for buildings
    /// </summary>

    public void UpdateMartianPeon()
    {
        martianPeonTotalCost = martianPeonBaseCost * Mathf.Pow(1.05f, martianPeonCount);
    }

    public void UpdateMartianBuilder()
    {
        martianBuilderTotalCost = martianBuilderBaseCost * Mathf.Pow(1.05f, martianBuilderCount);
    }

    public void UpdateMartianTaskMaster()
    {
        martianTaskMasterTotalCost = martianTaskMasterBaseCost * Mathf.Pow(1.05f, martianTaskMasterCount);
    }

    public void UpdateMartianEngineer()
    {
        martianEngineerTotalCost = martianEngineerBaseCost * Mathf.Pow(1.05f, martianEngineerCount);
    }

    public void UpdateMartianDoctor()
    {
        martianDoctorTotalCost = martianDoctorBaseCost * Mathf.Pow(1.05f, martianDoctorCount);
    }

    public void UpdateMartianScientist()
    {
        martianScientistTotalCost = martianScientistBaseCost * Mathf.Pow(1.05f, martianScientistCount);
    }

    /// <summary>
    /// Buy functions for items
    /// </summary>

    public void BuyTrainingCamp()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        if (eif.money >= 5000 && martianPeonCount >= 10)
        {
            trainingCampCount += 1;
            eif.money -= 5000;
            martianPeonCount -= 10;

            if (trainingCampCount == 1)
            {
                martianFactoryButton.SetActive(true);
                martianPowerPlantButton.SetActive(true);
                martianHospitalButton.SetActive(true);
                martianTaskMasterButton.SetActive(true);
                martianBuilderButton.SetActive(true);
                martianEngineerButton.SetActive(true);
                martianDoctorButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 4f);
                
                if (martianRestoreChance >= 10)
                {
                    martianRestoreChance = 10;
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

        if (eif.money >= 5000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 1 && martianPeonCount >= 10)
        {
            martianFarmCount += 1;
            eif.money -= 5000;
            martianPeonCount -= 10;
            martianBuilderCount -= 1;
            martianTaskMasterCount -= 1;

            if (trainingCampCount == 1 && martianFarmCount == 1 && martianMineCount == 1)
            {
                martianFactoryButton.SetActive(true);
                martianPowerPlantButton.SetActive(true);
                martianHospitalButton.SetActive(true);
                martianEngineerButton.SetActive(true);
                martianDoctorButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 4f);

                if (martianRestoreChance >= 10)
                {
                    martianRestoreChance = 10;
                }
                martianPeonCount += martianRestoreChance;
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

        if (eif.money >= 5000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 5 && martianPeonCount >= 10)
        {
            martianMineCount += 1;
            eif.money -= 5000;
            martianPeonCount -= 10;
            martianBuilderCount -= 5;
            martianTaskMasterCount -= 1;

            if (trainingCampCount == 1 && martianFarmCount == 1 && martianMineCount == 1)
            {
                martianFactoryButton.SetActive(true);
                martianPowerPlantButton.SetActive(true);
                martianHospitalButton.SetActive(true);
                martianEngineerButton.SetActive(true);
                martianDoctorButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 4f);

                if (martianRestoreChance >= 10)
                {
                    martianRestoreChance = 10;
                }
                martianPeonCount += martianRestoreChance;
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

        if (eif.money >= 50000 && martianTaskMasterCount >= 3 &&  martianBuilderCount >= 10 && martianEngineerCount >= 15 &&  martianPeonCount >= 30)
        {
            martianFactoryCount += 1;
            eif.money -= 50000;
            martianPeonCount -= 30;
            martianEngineerCount -= 15;
            martianBuilderCount -= 10;
            martianTaskMasterCount -= 3;

            if (martianFactoryCount == 1 && martianPowerPlantCount == 1 && martianHospitalCount == 1)
            {
                martianSatelliteButton.SetActive(true);
                martianResearchFacilityButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 10f);

                if (martianRestoreChance >= 30)
                {
                    martianRestoreChance = 30;
                }
                martianPeonCount += martianRestoreChance;
            }

            UpdateMartianFactory();

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

        if (eif.money >= 50000 && martianTaskMasterCount >= 3 && martianEngineerCount >= 5 && martianBuilderCount >= 10 &&  martianPeonCount >= 30)
        {
            martianPowerPlantCount += 1;
            eif.money -= 50000;
            martianPeonCount -= 30;
            martianBuilderCount -= 10;
            martianEngineerCount -= 5;
            martianTaskMasterCount -= 3;

            if (martianFactoryCount == 1 && martianPowerPlantCount == 1 && martianHospitalCount == 1)
            {
                martianSatelliteButton.SetActive(true);
                martianResearchFacilityButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 10f);

                if (martianRestoreChance >= 30)
                {
                    martianRestoreChance = 30;
                }
                martianPeonCount += martianRestoreChance;
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

        if (eif.money >= 50000 && martianTaskMasterCount >= 1 && martianBuilderCount >= 5 && martianDoctorCount >= 10 &&  martianPeonCount >= 30)
        {
            martianHospitalCount += 1;
            eif.money -= 50000;
            martianPeonCount -= 30;
            martianDoctorCount -= 10;
            martianBuilderCount -= 5;
            martianTaskMasterCount -= 1;

            if (martianFactoryCount == 1 && martianPowerPlantCount == 1 && martianHospitalCount == 1)
            {
                martianSatelliteButton.SetActive(true);
                martianResearchFacilityButton.SetActive(true);
                martianScientistButton.SetActive(true);
            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 10f);

                if (martianRestoreChance >= 30)
                {
                    martianRestoreChance = 30;
                }
                martianPeonCount += martianRestoreChance;
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

        if (eif.money >= 500000 && martianTaskMasterCount >= 2 && martianBuilderCount >= 10 && martianEngineerCount >= 10 && martianScientistCount >= 15 && martianPeonCount >= 40)
        {
            martianSatelliteCount += 1;
            eif.money -= 50000;
            martianPeonCount -= 40;
            martianScientistCount -= 15;
            martianEngineerCount -= 10;
            martianBuilderCount -= 10;
            martianTaskMasterCount -= 2;

            if (martianSatelliteCount == 1 && martianResearchFacilityCount == 1)
            {

            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 20f);

                if (martianRestoreChance >= 40)
                {
                    martianRestoreChance = 40;
                }
                martianPeonCount += martianRestoreChance;
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

        if (eif.money >= 500000 && martianTaskMasterCount >= 2 && martianBuilderCount >= 10 && martianEngineerCount >= 20 && martianScientistCount >= 20 && martianPeonCount >= 50)
        {
            martianResearchFacilityCount += 1;
            eif.money -= 50000;
            martianPeonCount -= 50;
            martianScientistCount -= 20;
            martianEngineerCount -= 20;
            martianBuilderCount -= 10;
            martianTaskMasterCount -= 2;

            if (martianSatelliteCount == 1 && martianResearchFacilityCount == 1)
            {

            }

            if (martianHospitalCount >= 1)
            {
                int martianRestoreChance = Mathf.RoundToInt((Random.value + 0.01f * martianHospitalCount) * 20f);

                if (martianRestoreChance >= 50)
                {
                    martianRestoreChance = 50;
                }
                martianPeonCount += martianRestoreChance;
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

            UpdateMartianHunter();

            SetMartianHunterText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianBuilder()
    {
        if (experience >= martianBuilderTotalCost && food >= 500 && martianCount >= 1)
        {
            martianBuilderCount += 1;
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
        if (experience >= 250 && food >= 750 && martianCount >= 1)
        {
            martianSoldierCount += 1;
            experience -= 250;
            food -= 750;
            martianCount -= 1;

            SetMartianSoldierText();
            SetMartianCountText();
            SetMoneyText();
            SetFoodText();
        }
    }

    public void BuyMartianPilot()
    {
        if (experience >= 350 && food >= 750 && martianCount >= 1)
        {
            martianSoldierCount += 1;
            experience -= 250;
            food -= 750;
            martianCount -= 1;

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
            }

            SetMartianCountText();
        }
    }


}
