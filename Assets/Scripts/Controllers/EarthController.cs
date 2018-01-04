using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class EarthController : MonoBehaviour
{ 
    /// <summary>
    /// Item variables
    /// </summary>

    public GameObject mainMenu;
    public GameObject reagantsPanel;
    public GameObject workersPanel;
    public GameObject resourcesUpgradesInterfacePanel;
    public GameObject statsPanel;
    public GameObject questsPanel;
    public GameObject spaceTravelPanel;
    public GameObject upgradesPanel;

    private string colour;
    private string colourEnd;
    private string red;
    private string green;

    [Header("Pizza and Money")]
    public float pizzas;
    public float money;
    public float clickMultiplierCount;
    public float priceMultiplierCount;
    public int convenientClickingCount;
    public float pizzasPerSecond;
    public Text moneyText;
    public Text pizzaText;
    public Text pizzasPerSecondText;

    [Header("Quest Button values")]
    public int rocketCount;
    public int crewCount;
    public int fuelCount;
    public Button rocketButton;
    public Button crewButton;
    public Button fuelButton;
    public GameObject marsTravelButton;

    [Header("Worker Variables")]
    public int workerCount;
    public int workerBaseCost;
    private float workerCostIncreaseRate;
    private float workerTotalCost;
    public Text workerCostText;
    public Text workerCountText;

    [Header("Pizza Cart Variables")]
    public int pizzaCartCount;
    public int pizzaCartBaseCost;
    private float pizzaCartCostIncreaseRate;
    private float pizzaCartTotalCost;
    public GameObject pizzaCartButton;
    public Text pizzaCartCostText;
    public Text pizzaCartCountText;

    [Header("Pizza Van Variables")]
    public int pizzaVanCount;
    public int pizzaVanBaseCost;
    private float pizzaVanCostIncreaseRate;
    private float pizzaVanTotalCost;
    public GameObject pizzaVanButton;
    public Text pizzaVanCostText;
    public Text pizzaVanCountText;

    [Header("Pizza Parlour Variables")]
    public int pizzaParlourCount;
    public int pizzaParlourBaseCost;
    private float pizzaParlourCostIncreaseRate;
    private float pizzaParlourTotalCost;
    public GameObject pizzaParlourButton;
    public Text pizzaParlourCostText;
    public Text pizzaParlourCountText;

    [Header("Pizza Restaurant Variables")]
    public int pizzaRestaurantCount;
    public int pizzaRestaurantBaseCost;
    private float pizzaRestaurantCostIncreaseRate;
    private float pizzaRestaurantTotalCost;
    public GameObject pizzaRestaurantButton;
    public Text pizzaRestaurantCostText;
    public Text pizzaRestaurantCountText;

    [Header("Pizza Palace Variables")]
    public int pizzaPalaceCount;
    public int pizzaPalaceBaseCost;
    private float pizzaPalaceCostIncreaseRate;
    private float pizzaPalaceTotalCost;
    public GameObject pizzaPalaceButton;
    public Text pizzaPalaceCostText;
    public Text pizzaPalaceCountText;

    [Header("Pizza Factory Variables")]
    public int pizzaFactoryCount;
    public int pizzaFactoryBaseCost;
    private float pizzaFactoryCostIncreaseRate;
    private float pizzaFactoryTotalCost;
    public GameObject pizzaFactoryButton;
    public Text pizzaFactoryCostText;
    public Text pizzaFactoryCountText;

    [Header("Pizza Converter Variables")]
    public int pizzaConverterCount;
    public int pizzaConverterBaseCost;
    private float pizzaConverterCostIncreaseRate;
    private float pizzaConverterTotalCost;
    public GameObject pizzaConverterButton;
    public Text pizzaConverterCostText;
    public Text pizzaConverterCountText;

    [Header("Pizza Weather Machine Variables")]
    public int pizzaWeatherMachineCount;
    public int pizzaWeatherMachineBaseCost;
    private float pizzaWeatherMachineCostIncreaseRate;
    private float pizzaWeatherMachineTotalCost;
    public GameObject pizzaWeatherMachineButton;
    public Text pizzaWeatherMachineCostText;
    public Text pizzaWeatherMachineCountText;

    [Header("Pizza Super Drill Variables")]
    public int pizzaSuperDrillCount;
    public int pizzaSuperDrillBaseCost;
    private float pizzaSuperDrillCostIncreaseRate;
    private float pizzaSuperDrillTotalCost;
    public GameObject pizzaSuperDrillButton;
    public Text pizzaSuperDrillCostText;
    public Text pizzaSuperDrillCountText;

    [Header("Pizza Moon Base Variables")]
    public int pizzaMoonBaseCount;
    public int pizzaMoonBaseBaseCost;
    private float pizzaMoonBaseCostIncreaseRate;
    private float pizzaMoonBaseTotalCost;
    public GameObject pizzaMoonBaseButton;
    public Text pizzaMoonBaseCostText;
    public Text pizzaMoonBaseCountText;

    /// <summary>
    /// Reagant variables
    /// </summary>

    [Header("Slave Variables")]
    public int slaveCount;
    public int slaveCost;
    public Text slaveCostText;
    public Text slaveCountText;

    [Header("Cleaner Variables")]
    public int cleanerCount;
    public int cleanerCost;
    public GameObject cleanerButton;
    public Text cleanerCostText;
    public Text cleanerCountText;

    [Header("Manager Variables")]
    public int managerCount;
    public int managerCost;
    public GameObject managerButton;
    public Text managerCostText;
    public Text managerCountText;

    [Header("Operator Variables")]
    public int operatorCount;
    public int operatorCost;
    public GameObject operatorButton;
    public Text operatorCostText;
    public Text operatorCountText;

    [Header("Scientist Variables")]
    public int scientistCount;
    public int scientistCost;
    public GameObject scientistButton;
    public Text scientistCostText;
    public Text scientistCountText;

    [Header("Astronaut Variables")]
    public int astronautCount;
    public int astronautCost;
    public GameObject astronautButton;
    public Text astronautCostText;
    public Text astronautCountText;

    [Header("Cart Variables")]
    public int cartCount;
    public int cartCost;
    public Text cartCostText;
    public Text cartCountText;

    [Header("Van Variables")]
    public int vanCount;
    public int vanCost;
    public GameObject vanButton;
    public Text vanCostText;
    public Text vanCountText;

    [Header("Parlour Variables")]
    public int parlourCount;
    public int parlourCost;
    public GameObject parlourButton;
    public Text parlourCostText;
    public Text parlourCountText;

    [Header("Restaurant Variables")]
    public int restaurantCount;
    public int restaurantCost;
    public GameObject restaurantButton;
    public Text restaurantCostText;
    public Text restaurantCountText;

    [Header("Palace Variables")]
    public int palaceCount;
    public int palaceCost;
    public GameObject palaceButton;
    public Text palaceCostText;
    public Text palaceCountText;

    [Header("Factory Variables")]
    public int factoryCount;
    public int factoryCost;
    public GameObject factoryButton;
    public Text factoryCostText;
    public Text factoryCountText;

    [Header("Converter Variables")]
    public int converterCount;
    public int converterCost;
    public GameObject converterButton;
    public Text converterCostText;
    public Text converterCountText;

    [Header("Scrap Metal Variables")]
    public int scrapMetalCount;
    public int scrapMetalCost;
    public GameObject scrapMetalButton;
    public Text scrapMetalCostText;
    public Text scrapMetalCountText;

    [Header("Weather Machine Variables")]
    public int weatherMachineCount;
    public int weatherMachineCost;
    public GameObject weatherMachineButton;
    public Text weatherMachineCostText;
    public Text weatherMachineCountText;

    [Header("Super Drill Variables")]
    public int superDrillCount;
    public int superDrillCost;
    public GameObject superDrillButton;
    public Text superDrillCostText;
    public Text superDrillCountText;

    [Header("SpaceElevator Variables")]
    public int spaceElevatorCount;
    public int spaceElevatorCost;
    public GameObject spaceElevatorButton;
    public Text spaceElevatorCostText;
    public Text spaceElevatorCountText;

    [Header("MoonBase Variables")]
    public int moonBaseCount;
    public int moonBaseCost;
    public GameObject moonBaseButton;
    public Text moonBaseCostText;
    public Text moonBaseCountText;

    [Header("MultiBarButtons")]
    public GameObject slaveMultiBuyButtons;
    public GameObject cleanerMultiBuyButtons;
    public GameObject managerMultiBuyButtons;
    public GameObject operatorMultiBuyButtons;
    public GameObject scientistMultiBuyButtons;
    public GameObject astronautMultiBuyButtons;
    public GameObject scrapMetalMultiBuyButtons;

    ///<summary>
    /// Upgrade Variables
    /// </summary>

    [Header("AutoClicker Variables")]
    public int autoClickerCost;
    public int autoClickerCount;
    public int autoClickerStrength;
    public GameObject autoClickerButton;
    public Text autoClickerCostText;

    [Header("ConvenientClickingOne Variables")]
    public int convenientClickingOneCost;
    public GameObject convenientClickingOneButton;
    public Text convenientClickingOneCostText;

    [Header("ConvenientClickingTwo Variables")]
    public int convenientClickingTwoCost;
    public GameObject convenientClickingTwoButton;
    public Text convenientClickingTwoCostText;

    [Header("ConvenientClickingThree Variables")]
    public int convenientClickingThreeCost;
    public GameObject convenientClickingThreeButton;
    public Text convenientClickingThreeCostText;

    [Header("UseTwoHands Variables")]
    public int useTwoHandsCost;
    public GameObject useTwoHandsButton;
    public Text useTwoHandsCostText;

    [Header("UseLegs Variables")]
    public int useLegsCost;
    public GameObject useLegsButton;
    public Text useLegsCostText;

    [Header("GrowClone Variables")]
    public int growCloneCost;
    public GameObject growCloneButton;
    public Text growCloneCostText;

    [Header("BodyModification Variables")]
    public int bodyModificationCost;
    public GameObject bodyModificationButton;
    public Text bodyModificationCostText;

    [Header("Pepperoni Variables")]
    public int pepperoniCost;
    public GameObject pepperoniButton;
    public Text pepperoniCostText;

    [Header("Chicken Variables")]
    public int chickenCost;
    public GameObject chickenButton;
    public Text chickenCostText;

    [Header("GroundBeef Variables")]
    public int groundBeefCost;
    public GameObject groundBeefButton;
    public Text groundBeefCostText;

    [Header("Sausage Variables")]
    public long sausageCost;
    public GameObject sausageButton;
    public Text sausageCostText;

    /// <summary>
    /// Text for stats panel
    /// </summary>

    [Header("Stat variables")]
    public Text pizzaStatText;
    public Text slaveStatText;
    public Text cleanerStatText;
    public Text managerStatText;
    public Text operatorStatText;
    public Text scientistStatText;
    public Text astronautStatText;
    public Text cartStatText;
    public Text vanStatText;
    public Text parlourStatText;
    public Text restaurantStatText;
    public Text palaceStatText;
    public Text factoryStatText;
    public Text converterStatText;
    public Text scrapMetalStatText;
    public Text weatherMachineStatText;
    public Text superDrillStatText;
    public Text spaceElevatorStatText;
    public Text moonBaseStatText;

    public float pizzaStatCounter;
    public int slaveStatCounter;
    public int cleanerStatCounter;
    public int managerStatCounter;
    public int operatorStatCounter;
    public int scientistStatCounter;
    public int astronautStatCounter;
    public int cartStatCounter;
    public int vanStatCounter;
    public int parlourStatCounter;
    public int restaurantStatCounter;
    public int palaceStatCounter;
    public int factoryStatCounter;
    public int converterStatCounter;
    public int scrapMetalStatCounter;
    public int weatherMachineStatCounter;
    public int superDrillStatCounter;
    public int spaceElevatorStatCounter;
    public int moonBaseStatCounter;

    /// <summary>
    /// Text box drop down gameobject holder
    /// </summary>

    [Header("Drop Down Text objects")]
    public GameObject pizzaCartDropDownTextBox;
    public GameObject pizzaVanDropDownTextBox;
    public GameObject pizzaParlourDropDownTextBox;
    public GameObject pizzaRestaurantDropDownTextBox;
    public GameObject pizzaPalaceDropDownTextBox;
    public GameObject pizzaFactoryDropDownTextBox;
    public GameObject pizzaConverterDropDownTextBox;
    public GameObject pizzaWeatherMachineDropDownTextBox;
    public GameObject pizzaSuperDrillDropDownTextBox;
    public GameObject pizzaMoonBaseDropDownTextBox;

    /// <summary>
    /// Start up functions and setting starting values
    /// </summary>

    private void Start()
    {
        UpdateWorker();
        UpdatePizzaCart();
        UpdatePizzaVan();
        UpdatePizzaParlour();
        UpdatePizzaRestaurant();
        UpdatePizzaPalace();
        UpdatePizzaFactory();
        UpdatePizzaConverter();
        UpdatePizzaWeatherMachine();
        UpdatePizzaSuperDrill();
        UpdatePizzaMoonBase();

        SetPizzaText();
        SetMoneyText();
        SetPizzasPerSecondText();
        UpdateStats();
        SetWorkerText();
        SetCleanerText();
        SetManagerText();
        SetPizzaCartText();
        SetPizzaVanText();
        SetPizzaParlourText();
        SetPizzaRestaurantText();
        SetPizzaPalaceText();
        SetPizzaFactoryText();
        SetPizzaConverterText();
        SetPizzaWeatherMachineText();
        SetPizzaSuperDrillText();
        SetPizzaMoonBaseText();

        SetSlaveText();
        SetCleanerText();
        SetManagerText();
        SetOperatorText();
        SetScientistText();
        SetAstronautText();
        SetCartText();
        SetVanText();
        SetParlourText();
        SetRestaurantText();
        SetPalaceText();
        SetFactoryText();
        SetConverterText();
        SetScrapMetalText();
        SetWeatherMachineText();
        SetSuperDrillText();
        SetSpaceElevatorText();
        SetMoonBaseText();

        SetAutoClickerText();
        SetConvenientClickingOneText();
        SetConvenientClickingTwoText();
        SetConvenientClickingThreeText();
        SetUseTwoHandsText();
        SetUseLegsText();
        SetGrowCloneText();
        SetBodyModificationText();
        SetPepperoniText();
        SetChickenText();
        SetGroundBeefText();
        SetSausageText();
    }

    /// <summary>
    /// Actions that need updating every frame
    /// </summary>

    private void Update()
    {
        pizzasPerSecond = workerCount * 0.5f + pizzaCartCount * 2f + pizzaVanCount * 6f + pizzaParlourCount * 20f + pizzaRestaurantCount * 60f + pizzaPalaceCount * 180f + pizzaFactoryCount * 400f + pizzaConverterCount * 10000f + pizzaWeatherMachineCount * 30000f + pizzaSuperDrillCount * 75000f + pizzaMoonBaseCount * 200000f;
        pizzas += pizzasPerSecond * Time.deltaTime;
        pizzas += autoClickerStrength * autoClickerCount* Mathf.Pow(2, clickMultiplierCount) * Time.deltaTime;
        SetPizzaText();

        // Used to open up the main menu

        if (Input.GetKeyDown("escape"))
        {
            mainMenu.SetActive(!mainMenu.activeSelf);
        }

        // This controls the colour for all the items 

        if (money >= workerTotalCost)
        {
            workerCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            workerCostText.color = Color.red;

        if (money >= pizzaCartTotalCost)
        {
            pizzaCartCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaCartCostText.color = Color.red;

        if (money >= pizzaVanTotalCost)
        {
            pizzaVanCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaVanCostText.color = Color.red;

        if (money >= pizzaParlourTotalCost)
        {
            pizzaParlourCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaParlourCostText.color = Color.red;

        if (money >= pizzaRestaurantTotalCost)
        {
            pizzaRestaurantCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaRestaurantCostText.color = Color.red;

        if (money >= pizzaPalaceTotalCost)
        {
            pizzaPalaceCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaPalaceCostText.color = Color.red;

        if (money >= pizzaFactoryTotalCost)
        {
            pizzaFactoryCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaFactoryCostText.color = Color.red;

        if (money >= pizzaConverterTotalCost)
        {
            pizzaConverterCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaConverterCostText.color = Color.red;

        if (money >= pizzaWeatherMachineTotalCost)
        {
            pizzaWeatherMachineCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaWeatherMachineCostText.color = Color.red;

        if (money >= pizzaSuperDrillTotalCost)
        {
            pizzaSuperDrillCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaSuperDrillCostText.color = Color.red;

        if (money >= pizzaMoonBaseTotalCost)
        {
            pizzaMoonBaseCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pizzaMoonBaseCostText.color = Color.red;

        // This controls colour for all the reagants

        if (money >= slaveCost)
        {
            slaveCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            slaveCostText.color = Color.red;

        if (money >= cleanerCost)
        {
            cleanerCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            cleanerCostText.color = Color.red;

        if (money >= managerCost)
        {
            managerCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            managerCostText.color = Color.red;

        if (money >= operatorCost)
        {
            operatorCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            operatorCostText.color = Color.red;

        if (money >= scientistCost)
        {
            scientistCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            scientistCostText.color = Color.red;

        if (money >= astronautCost)
        {
            astronautCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            astronautCostText.color = Color.red;

        if (money >= cartCost)
        {
            cartCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            cartCostText.color = Color.red;

        if (money >= vanCost)
        {
            vanCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            vanCostText.color = Color.red;

        if (money >= parlourCost)
        {
            parlourCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            parlourCostText.color = Color.red;

        if (money >= restaurantCost)
        {
            restaurantCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            restaurantCostText.color = Color.red;

        if (money >= palaceCost)
        {
            palaceCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            palaceCostText.color = Color.red;

        if (money >= factoryCost)
        {
            factoryCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            factoryCostText.color = Color.red;

        if (money >= scrapMetalCost)
        {
            scrapMetalCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            scrapMetalCostText.color = Color.red;

        if (money >= converterCost)
        {
            converterCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            converterCostText.color = Color.red;

        if (money >= weatherMachineCost)
        {
            weatherMachineCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            weatherMachineCostText.color = Color.red;

        if (money >= superDrillCost)
        {
            superDrillCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            superDrillCostText.color = Color.red;

        if (money >= spaceElevatorCost)
        {
            spaceElevatorCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            spaceElevatorCostText.color = Color.red;

        if (money >= moonBaseCost)
        {
            moonBaseCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            moonBaseCostText.color = Color.red;

        if (money >= autoClickerCost)
        {
            autoClickerCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            autoClickerCostText.color = Color.red;

        if (money >= convenientClickingOneCost)
        {
            convenientClickingOneCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            convenientClickingOneCostText.color = Color.red;

        if (money >= convenientClickingTwoCost)
        {
            convenientClickingTwoCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            convenientClickingTwoCostText.color = Color.red;

        if (money >= convenientClickingThreeCost)
        {
            convenientClickingThreeCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            convenientClickingThreeCostText.color = Color.red;

        if (money >= useTwoHandsCost)
        {
            useTwoHandsCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            useTwoHandsCostText.color = Color.red;

        if (money >= useLegsCost)
        {
            useLegsCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            useLegsCostText.color = Color.red;

        if (money >= growCloneCost)
        {
            growCloneCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            growCloneCostText.color = Color.red;

        if (money >= bodyModificationCost)
        {
            bodyModificationCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            bodyModificationCostText.color = Color.red;

        if (money >= pepperoniCost)
        {
            pepperoniCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            pepperoniCostText.color = Color.red;

        if (money >= chickenCost)
        {
            chickenCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else chickenCostText.color = Color.red;

        if (money >= groundBeefCost)
        {
            groundBeefCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            groundBeefCostText.color = Color.red;

        if (money >= sausageCost)
        {
            sausageCostText.color = new Color(0f, 216f / 255f, 0f);
        }
        else
            sausageCostText.color = Color.red;
    }

    /// <summary>
    /// Core components of the game
    /// </summary>

    public void PizzaClick()
    {
        pizzas += 1 * Mathf.Pow(2, clickMultiplierCount);
        pizzaStatCounter += 1;
        UpdateStats();
        SetPizzaText();
    }

    public void SellPizzas()
    {
        money += pizzas*(1+priceMultiplierCount);
        pizzas = 0;
        SetPizzaText();
        SetMoneyText();
    }

    /// <summary>
    /// Toggle the scrollbar on/off command
    /// </summary>

    public void ToggleScrollbar(GameObject scrollbar)
    {
        scrollbar.SetActive(!scrollbar.activeSelf);
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
    /// Setting Text functions for items
    /// </summary>

    public void SetPizzaText()
    {
        pizzaText.text = "Pizzas: " + pizzas.ToString("f0");
    }

    public void SetMoneyText()
    {
        moneyText.text = "Money: £" + money.ToString("f0");
    }

    public void SetPizzasPerSecondText()
    {
        pizzasPerSecondText.text = "Pizzas per second: " + pizzasPerSecond;
    }

    public void SetWorkerText()
    {
        workerCostText.text = "£" + workerTotalCost.ToString("f0");
        workerCountText.text = workerCount.ToString("f0");
    }

    public void SetPizzaCartText()
    {
        pizzaCartCostText.text = "£" + pizzaCartTotalCost.ToString("f0");
        pizzaCartCountText.text = pizzaCartCount.ToString("f0");
    }

    public void SetPizzaVanText()
    {
        pizzaVanCostText.text = "£" + pizzaVanTotalCost.ToString("f0");
        pizzaVanCountText.text = pizzaVanCount.ToString("f0");
    }

    public void SetPizzaParlourText()
    {
        pizzaParlourCostText.text = "£" + pizzaParlourTotalCost.ToString("f0");
        pizzaParlourCountText.text = pizzaParlourCount.ToString("f0");
    }

    public void SetPizzaRestaurantText()
    {
        pizzaRestaurantCostText.text = "£" + pizzaRestaurantTotalCost.ToString("f0");
        pizzaRestaurantCountText.text = pizzaRestaurantCount.ToString("f0");
    }

    public void SetPizzaPalaceText()
    {
        pizzaPalaceCostText.text = "£" + pizzaPalaceTotalCost.ToString("f0");
        pizzaPalaceCountText.text = pizzaPalaceCount.ToString("f0");
    }

    public void SetPizzaFactoryText()
    {
        pizzaFactoryCostText.text = "£" + pizzaFactoryTotalCost.ToString("f0");
        pizzaFactoryCountText.text = pizzaFactoryCount.ToString("f0");
    }

    public void SetPizzaConverterText()
    {
        pizzaConverterCostText.text = "£" + pizzaConverterTotalCost.ToString("f0");
        pizzaConverterCountText.text = pizzaConverterCount.ToString("f0");
    }

    public void SetPizzaWeatherMachineText()
    {
        pizzaWeatherMachineCostText.text = "£" + pizzaWeatherMachineTotalCost.ToString("f0");
        pizzaWeatherMachineCountText.text = pizzaWeatherMachineCount.ToString("f0");
    }

    public void SetPizzaSuperDrillText()
    {
        pizzaSuperDrillCostText.text = "£" + pizzaSuperDrillTotalCost.ToString("f0");
        pizzaSuperDrillCountText.text = pizzaSuperDrillCount.ToString("f0");
    }

    public void SetPizzaMoonBaseText()
    {
        pizzaMoonBaseCostText.text = "£" + pizzaMoonBaseTotalCost.ToString("f0");
        pizzaMoonBaseCountText.text = pizzaMoonBaseCount.ToString("f0");
    }

    /// <summary>
    /// Setting Text functions for reagants
    /// </summary>

    public void SetSlaveText()
    {
        slaveCostText.text = "£" + slaveCost.ToString("f0");
        slaveCountText.text = slaveCount.ToString("f0");
    }

    public void SetCleanerText()
    {
        cleanerCostText.text = "£" + cleanerCost.ToString("f0");
        cleanerCountText.text = cleanerCount.ToString("f0");
    }

    public void SetManagerText()
    {
        managerCostText.text = "£" + managerCost.ToString("f0");
        managerCountText.text = managerCount.ToString("f0");
    }

    public void SetOperatorText()
    {
        operatorCostText.text = "£" + operatorCost.ToString("f0");
        operatorCountText.text = operatorCount.ToString("f0");
    }

    public void SetScientistText()
    {
        scientistCostText.text = "£" + scientistCost.ToString("f0");
        scientistCountText.text = scientistCount.ToString("f0");
    }

    public void SetAstronautText()
    {
        astronautCostText.text = "£" + astronautCost.ToString("f0");
        astronautCountText.text = astronautCount.ToString("f0");
    }

    public void SetCartText()
    {
        cartCostText.text = "£" + cartCost.ToString("f0");
        cartCountText.text = cartCount.ToString("f0");
    }

    public void SetVanText()
    {
        vanCostText.text = "£" + vanCost.ToString("f0");
        vanCountText.text = vanCount.ToString("f0");
    }

    public void SetParlourText()
    {
        parlourCostText.text = "£" + parlourCost.ToString("f0");
        parlourCountText.text = parlourCount.ToString("f0");
    }

    public void SetRestaurantText()
    {
        restaurantCostText.text = "£" + restaurantCost.ToString("f0");
        restaurantCountText.text = restaurantCount.ToString("f0");
    }

    public void SetPalaceText()
    {
        palaceCostText.text = "£" + palaceCost.ToString("f0");
        palaceCountText.text = palaceCount.ToString("f0");
    }

    public void SetFactoryText()
    {
        factoryCostText.text = "£" + factoryCost.ToString("f0");
        factoryCountText.text = factoryCount.ToString("f0");
    }

    public void SetConverterText()
    {
        converterCostText.text = "£" + converterCost.ToString("f0");
        converterCountText.text = converterCount.ToString("f0");
    }

    public void SetScrapMetalText()
    {
        scrapMetalCostText.text = "£" + scrapMetalCost.ToString("f0");
        scrapMetalCountText.text = scrapMetalCount.ToString("f0");
    }

    public void SetWeatherMachineText()
    {
        weatherMachineCostText.text = "£" + weatherMachineCost.ToString("f0");
        weatherMachineCountText.text = weatherMachineCount.ToString("f0");
    }

    public void SetSuperDrillText()
    {
        superDrillCostText.text = "£" + superDrillCost.ToString("f0");
        superDrillCountText.text = superDrillCount.ToString("f0");
    }

    public void SetSpaceElevatorText()
    {
        spaceElevatorCostText.text = "£" + spaceElevatorCost.ToString("f0");
        spaceElevatorCountText.text = spaceElevatorCount.ToString("f0");
    }

    public void SetMoonBaseText()
    {
        moonBaseCostText.text = "£" + moonBaseCost.ToString("f0");
        moonBaseCountText.text = moonBaseCount.ToString("f0");
    }

    /// <summary>
    /// Setting text functions for upgrades
    /// </summary>

    public void SetAutoClickerText()
    {
        autoClickerCostText.text = "£" + autoClickerCost.ToString("f0");
    }

    public void SetConvenientClickingOneText()
    {
        convenientClickingOneCostText.text = "£" + convenientClickingOneCost.ToString("f0");
    }

    public void SetConvenientClickingTwoText()
    {
        convenientClickingTwoCostText.text = "£" + convenientClickingTwoCost.ToString("f0");
    }

    public void SetConvenientClickingThreeText()
    {
        convenientClickingThreeCostText.text = "£" + convenientClickingThreeCost.ToString("f0");
    }

    public void SetUseTwoHandsText()
    {
        useTwoHandsCostText.text = "£" + useTwoHandsCost.ToString("f0");
    }

    public void SetUseLegsText()
    {
        useLegsCostText.text = "£" + useLegsCost.ToString("f0");
    }

    public void SetGrowCloneText()
    {
        growCloneCostText.text = "£" + growCloneCost.ToString("f0");
    }

    public void SetBodyModificationText()
    {
        bodyModificationCostText.text = "£" + bodyModificationCost.ToString("f0");
    }

    public void SetPepperoniText()
    {
        pepperoniCostText.text = "£" + pepperoniCost.ToString("f0");
    }

    public void SetChickenText()
    {
        chickenCostText.text = "£" + chickenCost.ToString("f0");
    }

    public void SetGroundBeefText()
    {
        groundBeefCostText.text = "£" + groundBeefCost.ToString("f0");
    }

    public void SetSausageText()
    {
        sausageCostText.text = "£" + sausageCost.ToString("f0");
    }

    /// <summary>
    /// Text functions for stats
    /// </summary>

    public void UpdateStats()
    {
        pizzaStatText.text = "Pizzas made: " + pizzaStatCounter.ToString("f0");
        slaveStatText.text = "Slaves hired: " + slaveStatCounter.ToString("f0");
        cleanerStatText.text = "Cleaners hired: " + cleanerStatCounter.ToString("f0");
        managerStatText.text = "Managers hired: " + managerStatCounter.ToString("f0");
        operatorStatText.text = "Operators hired: " + operatorStatCounter.ToString("f0");
        scientistStatText.text = "Scientists hired: " + scientistStatCounter.ToString("f0");
        astronautStatText.text = "Astronauts hired: " + astronautStatCounter.ToString("f0");
        cartStatText.text = "Carts made: " + cartStatCounter.ToString("f0");
        vanStatText.text = "Vans made: " + vanStatCounter.ToString("f0");
        parlourStatText.text = "Parlours made: " + parlourStatCounter.ToString("f0");
        restaurantStatText.text = "Restaurants made: " + restaurantStatCounter.ToString("f0");
        palaceStatText.text = "Palaces made: " + palaceStatCounter.ToString("f0");
        factoryStatText.text = "Factories made: " + factoryStatCounter.ToString("f0");
        converterStatText.text = "Converters made: " + converterStatCounter.ToString("f0");
        weatherMachineStatText.text = "Weather Machines made: " + weatherMachineStatCounter.ToString("f0");
        superDrillStatText.text = "Super Drills made: " + superDrillStatCounter.ToString("f0");
        spaceElevatorStatText.text = "Space Elevators made: " + spaceElevatorStatCounter.ToString("f0");
        moonBaseStatText.text = "Moon Bases made: " + moonBaseStatCounter.ToString("f0");
    }

    /// <summary>
    /// Update value functions
    /// </summary>

    public void UpdatePizzasPerSecond()
    {
        pizzasPerSecond = workerCount * 0.5f + pizzaCartCount * 2f + pizzaVanCount * 6f + pizzaParlourCount * 20f + pizzaRestaurantCount * 60f + pizzaPalaceCount * 180f + pizzaFactoryCount * 400f + pizzaConverterCount * 10000f + pizzaWeatherMachineCount * 30000f + pizzaSuperDrillCount * 75000f + pizzaMoonBaseCount * 200000f;
    }

    public void UpdateWorker()
    {
        workerTotalCost = workerBaseCost * Mathf.Pow(1.05f, workerCount);
    }  

    public void UpdatePizzaCart()
    {
        pizzaCartTotalCost = pizzaCartBaseCost * Mathf.Pow(1.05f, pizzaCartCount);
    }

    public void UpdatePizzaVan()
    {
        pizzaVanTotalCost = pizzaVanBaseCost * Mathf.Pow(1.05f, pizzaVanCount);
    }

    public void UpdatePizzaParlour()
    {
        pizzaParlourTotalCost = pizzaParlourBaseCost * Mathf.Pow(1.05f, pizzaParlourCount);
    }

    public void UpdatePizzaRestaurant()
    {
        pizzaRestaurantTotalCost = pizzaRestaurantBaseCost * Mathf.Pow(1.05f, pizzaRestaurantCount);
    }

    public void UpdatePizzaPalace()
    {
        pizzaPalaceTotalCost = pizzaPalaceBaseCost * Mathf.Pow(1.05f, pizzaPalaceCount);
    }

    public void UpdatePizzaFactory()
    {
        pizzaFactoryTotalCost = pizzaFactoryBaseCost * Mathf.Pow(1.05f, pizzaFactoryCount);
    }

    public void UpdatePizzaConverter()
    {
        pizzaConverterTotalCost = pizzaConverterBaseCost * Mathf.Pow(1.05f, pizzaConverterCount);
    }

    public void UpdatePizzaWeatherMachine()
    {
        pizzaWeatherMachineTotalCost = pizzaWeatherMachineBaseCost * Mathf.Pow(1.05f, pizzaWeatherMachineCount);
    }

    public void UpdatePizzaSuperDrill()
    {
        pizzaSuperDrillTotalCost = pizzaSuperDrillBaseCost * Mathf.Pow(1.05f, pizzaSuperDrillCount);
    }

    public void UpdatePizzaMoonBase()
    {
        pizzaMoonBaseTotalCost = pizzaMoonBaseBaseCost * Mathf.Pow(1.05f, pizzaMoonBaseCount);
    }

    ///<summary>
    /// Colour control of the interface panels
    /// </summary>

    public void ResourcesInterfaceActivate()
    {
        GameObject resourcesUpgradesInterfaceButton = GameObject.Find("ResourcesUpgradesInterfaceButton");
        GameObject questsInterfaceButton = GameObject.Find("QuestsInterfaceButton");
        GameObject spaceTravelInterfaceButton = GameObject.Find("SpaceTravelInterfaceButton");
        GameObject statsInterfaceButton = GameObject.Find("StatsInterfaceButton");

        resourcesUpgradesInterfacePanel.SetActive(true);
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
        GameObject resourcesUpgradesInterfaceButton = GameObject.Find("ResourcesUpgradesInterfaceButton");
        GameObject questsInterfaceButton = GameObject.Find("QuestsInterfaceButton");
        GameObject spaceTravelInterfaceButton = GameObject.Find("SpaceTravelInterfaceButton");
        GameObject statsInterfaceButton = GameObject.Find("StatsInterfaceButton");

        resourcesUpgradesInterfacePanel.SetActive(false);
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
        GameObject resourcesUpgradesInterfaceButton = GameObject.Find("ResourcesUpgradesInterfaceButton");
        GameObject questsInterfaceButton = GameObject.Find("QuestsInterfaceButton");
        GameObject spaceTravelInterfaceButton = GameObject.Find("SpaceTravelInterfaceButton");
        GameObject statsInterfaceButton = GameObject.Find("StatsInterfaceButton");

        resourcesUpgradesInterfacePanel.SetActive(false);
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
        GameObject resourcesUpgradesInterfaceButton = GameObject.Find("ResourcesUpgradesInterfaceButton");
        GameObject questsInterfaceButton = GameObject.Find("QuestsInterfaceButton");
        GameObject spaceTravelInterfaceButton = GameObject.Find("SpaceTravelInterfaceButton");
        GameObject statsInterfaceButton = GameObject.Find("StatsInterfaceButton");

        resourcesUpgradesInterfacePanel.SetActive(false);
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

    public void BuyWorker()
    {
        if (money >= workerTotalCost)
        {
            workerCount += 1;
            money -= workerTotalCost;

            if (workerCount == 1)
            {
                pizzaCartButton.SetActive(true);
                pizzaCartDropDownTextBox.SetActive(true);
                reagantsPanel.SetActive(true);
                workersPanel.SetActive(true);
            }

            UpdateWorker();
            UpdatePizzasPerSecond();
            SetWorkerText();
            SetMoneyText();
            SetPizzasPerSecondText();
        }
    }

    public void BuyPizzaCart()
    {
        if (money >= pizzaCartTotalCost && slaveCount >=1 && cartCount>=1)
        {
            pizzaCartCount += 1;
            money -= pizzaCartTotalCost;
            slaveCount -= 1;
            cartCount -= 1;

            if (pizzaCartCount == 1)
            {
                pizzaVanButton.SetActive(true);
                pizzaVanDropDownTextBox.SetActive(true);
                vanButton.SetActive(true);
                upgradesPanel.SetActive(true);
                autoClickerButton.SetActive(true);
            }

            UpdatePizzaCart();
            UpdatePizzasPerSecond();
            SetPizzaCartText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCartText();
        }
    }

    public void BuyPizzaVan()
    {
        if(money >= pizzaVanTotalCost && slaveCount >=2 && vanCount >=1)
        {
            pizzaVanCount += 1;
            money -= pizzaVanTotalCost;
            slaveCount -= 2;
            vanCount -= 1;

            if (pizzaVanCount == 1)
            {
                pizzaParlourButton.SetActive(true);
                pizzaParlourDropDownTextBox.SetActive(true);
                cleanerButton.SetActive(true);
                managerButton.SetActive(true);
                parlourButton.SetActive(true);
            }

            UpdatePizzaVan();
            UpdatePizzasPerSecond();
            SetPizzaVanText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetVanText();
        }
    }

    public void BuyPizzaParlour()
    {
        if (money >= pizzaParlourTotalCost && slaveCount >=3 && cleanerCount >=1 && managerCount >=1 && parlourCount >=1)
        {
            pizzaParlourCount += 1;
            money -= pizzaParlourTotalCost;
            slaveCount -= 3;
            cleanerCount -= 1;
            managerCount -= 1;
            parlourCount -= 1;

            if (pizzaParlourCount == 1)
            {
                pizzaRestaurantButton.SetActive(true);
                pizzaRestaurantDropDownTextBox.SetActive(true);
                restaurantButton.SetActive(true);
                convenientClickingOneButton.SetActive(true);
            }

            UpdatePizzaParlour();
            UpdatePizzasPerSecond();
            SetPizzaParlourText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetManagerText();
            SetParlourText();
        }
    }

    public void BuyPizzaRestaurant()
    {
        if (money >= pizzaRestaurantTotalCost && slaveCount >=8 && cleanerCount >=2 && managerCount >=1 && restaurantCount >=1)
        {
            pizzaRestaurantCount += 1;
            money -= pizzaRestaurantTotalCost;
            slaveCount -= 8;
            cleanerCount -= 2;
            managerCount -= 1;
            restaurantCount -= 1;

            if (pizzaRestaurantCount == 1)
            {
                pizzaPalaceButton.SetActive(true);
                pizzaPalaceDropDownTextBox.SetActive(true);
                palaceButton.SetActive(true);
                useTwoHandsButton.SetActive(true);
            }

            UpdatePizzaRestaurant();
            UpdatePizzasPerSecond();
            SetPizzaRestaurantText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetManagerText();
            SetRestaurantText();
        }
    }

    public void BuyPizzaPalace()
    {
        if (money >= pizzaPalaceTotalCost && slaveCount >=16 && cleanerCount >=4 && managerCount >=2 && palaceCount >= 1)
        {
            pizzaPalaceCount += 1;
            money -= pizzaPalaceTotalCost;
            slaveCount -= 16;
            cleanerCount -= 4;
            managerCount -= 2;
            palaceCount -= 1;

            if (pizzaPalaceCount == 1)
            {
                pizzaFactoryButton.SetActive(true);
                pizzaFactoryDropDownTextBox.SetActive(true);
                factoryButton.SetActive(true);
            }

            UpdatePizzaPalace();
            UpdatePizzasPerSecond();
            SetPizzaPalaceText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetManagerText();
            SetPalaceText();
        }
    }

    public void BuyPizzaFactory()
    {
        if (money >= pizzaFactoryTotalCost && slaveCount >=32 && cleanerCount >=8 && managerCount >=4 && factoryCount >=1)
        {
            pizzaFactoryCount += 1;
            money -= pizzaFactoryTotalCost;
            slaveCount -= 32;
            cleanerCount -= 8;
            managerCount -= 4;
            factoryCount -= 1;

            if (pizzaFactoryCount == 1)
            {
                pizzaConverterButton.SetActive(true);
                pizzaConverterDropDownTextBox.SetActive(true);
                converterButton.SetActive(true);
                scrapMetalButton.SetActive(true);
                operatorButton.SetActive(true);
                scientistButton.SetActive(true);
                convenientClickingTwoButton.SetActive(true);
                pepperoniButton.SetActive(true);
            }

            UpdatePizzaFactory();
            UpdatePizzasPerSecond();
            SetPizzaFactoryText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetManagerText();
            SetFactoryText();
        }
    }

    public void BuyPizzaConverter()
    {
        if (money >= pizzaConverterTotalCost && slaveCount >=64 && cleanerCount >=16 && operatorCount >=8 && scientistCount >=4 && scrapMetalCount >=10 && converterCount >=1)
        {
            pizzaConverterCount += 1;
            money -= pizzaConverterTotalCost;
            slaveCount -= 64;
            cleanerCount -= 16;
            operatorCount -= 8;
            scientistCount -= 4;
            scrapMetalCount -= 10;
            converterCount -= 1;

            if (pizzaConverterCount == 1)
            {
                pizzaWeatherMachineButton.SetActive(true);
                pizzaWeatherMachineDropDownTextBox.SetActive(true);
                weatherMachineButton.SetActive(true);
            }

            UpdatePizzaConverter();
            UpdatePizzasPerSecond();
            SetPizzaConverterText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetOperatorText();
            SetScientistText();
            SetScrapMetalText();
            SetConverterText();
        }
    }

    public void BuyPizzaWeatherMachine()
    {
        if (money >= pizzaWeatherMachineTotalCost && slaveCount >=128 && cleanerCount >=32 && operatorCount >=16 && scientistCount >=8 && scrapMetalCount >=20 && weatherMachineCount >=1)
        {
            pizzaWeatherMachineCount += 1;
            money -= pizzaWeatherMachineTotalCost;
            slaveCount -= 128;
            cleanerCount -= 32;
            operatorCount -= 16;
            scientistCount -= 8;
            scrapMetalCount -= 20;
            weatherMachineCount -= 1;

            if (pizzaWeatherMachineCount == 1)
            {
                pizzaSuperDrillButton.SetActive(true);
                pizzaSuperDrillDropDownTextBox.SetActive(true);
                superDrillButton.SetActive(true);
            }

            UpdatePizzaWeatherMachine();
            UpdatePizzasPerSecond();
            SetPizzaWeatherMachineText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetOperatorText();
            SetScientistText();
            SetScrapMetalText();
            SetPizzaWeatherMachineText();
        }
    }

    public void BuyPizzaSuperDrill()
    {
        if (money >= pizzaSuperDrillTotalCost && slaveCount >=256 && cleanerCount >=64 && operatorCount >=32 && scientistCount >=16 && scrapMetalCount >=30 && superDrillCount >=1)
        {
            pizzaSuperDrillCount += 1;
            money -= pizzaSuperDrillTotalCost;
            slaveCount -= 256;
            cleanerCount -= 64;
            operatorCount -= 32;
            scientistCount -= 16;
            scrapMetalCount -= 30;
            superDrillCount -= 1;

            if (pizzaSuperDrillCount == 1)
            {
                pizzaMoonBaseButton.SetActive(true);
                pizzaMoonBaseDropDownTextBox.SetActive(true);
                astronautButton.SetActive(true);
                spaceElevatorButton.SetActive(true);
                moonBaseButton.SetActive(true);
                convenientClickingThreeButton.SetActive(true);
            }

            UpdatePizzaSuperDrill();
            UpdatePizzasPerSecond();
            SetPizzaSuperDrillText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetOperatorText();
            SetScientistText();
            SetScrapMetalText();
            SetPizzaSuperDrillText();
        }
    }

    public void BuyPizzaMoonBase()
    {
        if (money >= pizzaMoonBaseTotalCost && slaveCount >= 512 && cleanerCount >=128  && operatorCount >=64 && scientistCount >=32 && astronautCount >=16 && scrapMetalCount >=50 && spaceElevatorCount >=2 && moonBaseCount >=1)
        {
            pizzaMoonBaseCount += 1;
            money -= pizzaMoonBaseTotalCost;
            slaveCount -= 512;
            cleanerCount -= 128;
            operatorCount -= 64;
            scientistCount -= 32;
            astronautCount -= 16;
            scrapMetalCount -= 50;
            spaceElevatorCount -= 2;
            moonBaseCount -= 1;

            if (pizzaMoonBaseCount >= 1)
            {
                rocketButton.interactable = true;
                crewButton.interactable = true;
                fuelButton.interactable = true;
            }

            UpdatePizzaMoonBase();
            UpdatePizzasPerSecond();
            SetPizzaMoonBaseText();
            SetMoneyText();
            SetPizzasPerSecondText();
            SetSlaveText();
            SetCleanerText();
            SetOperatorText();
            SetScientistText();
            SetScrapMetalText();
            SetSpaceElevatorText();
            SetMoonBaseText();
            SetPizzaMoonBaseText();
        }
    }

    /// <summary>
    /// Buy functions for reagants
    /// </summary>

    public void BuySlave()
    {
        if (money >= slaveCost)
        {
            slaveCount += 1;
            slaveStatCounter += 1;
            money -= slaveCost;
            SetSlaveText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10Slave()
    {
        if (money >= slaveCost*10)
        {
            for (var i=0; i<10; i++)
            {
                BuySlave();
            }
        }
    }

    public void Buy100Slave()
    {
        if (money >= slaveCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuySlave();
            }
        }
    }

    public void Buy1000Slave()
    {
        if (money >= slaveCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuySlave();
            }
        }
    }

    public void BuyCleaner()
    {
        if (money >= cleanerCost)
        {
            cleanerCount += 1;
            cleanerStatCounter += 1;
            money -= cleanerCost;
            SetCleanerText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10Cleaner()
    {
        if (money >= cleanerCost * 10)
        {
            for (var i = 0; i < 10; i++)
            {
                BuyCleaner();
            }
        }
    }

    public void Buy100Cleaner()
    {
        if (money >= cleanerCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuyCleaner();
            }
        }
    }

    public void Buy1000Cleaner()
    {
        if (money >= cleanerCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuyCleaner();
            }
        }
    }

    public void BuyManager()
    {
        if (money >= managerCost)
        {
            managerCount += 1;
            managerStatCounter += 1;
            money -= managerCost;
            SetManagerText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10Manager()
    {
        if (money >= managerCost * 10)
        {
            for (var i = 0; i < 10; i++)
            {
                BuyManager();
            }
        }
    }

    public void Buy100Manager()
    {
        if (money >= managerCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuyManager();
            }
        }
    }

    public void Buy1000Manager()
    {
        if (money >= managerCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuyManager();
            }
        }
    }

    public void BuyOperator()
    {
        if (money >= operatorCost)
        {
            operatorCount += 1;
            operatorStatCounter += 1;
            money -= operatorCost;
            SetOperatorText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10Operator()
    {
        if (money >= operatorCost * 10)
        {
            for (var i = 0; i < 10; i++)
            {
                BuyOperator();
            }
        }
    }

    public void Buy100Operator()
    {
        if (money >= operatorCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuyOperator();
            }
        }
    }

    public void Buy1000Operator()
    {
        if (money >= operatorCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuyOperator();
            }
        }
    }

    public void BuyScientist()
    {
        if (money >= scientistCost)
        {
            scientistCount += 1;
            scientistStatCounter += 1;
            money -= scientistCost;
            SetScientistText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10Scientist()
    {
        if (money >= scientistCost * 10)
        {
            for (var i = 0; i < 10; i++)
            {
                BuyScientist();
            }
        }
    }

    public void Buy100Scientist()
    {
        if (money >= scientistCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuyScientist();
            }
        }
    }

    public void Buy1000Scientist()
    {
        if (money >= scientistCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuyScientist();
            }
        }
    }

    public void BuyCart()
    {
        if(money >= cartCost)
        {
            cartCount += 1;
            cartStatCounter += 1;
            money -= cartCost;
            SetCartText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyAstronaut()
    {
        if (money >= astronautCost)
        {
            astronautCount += 1;
            astronautStatCounter += 1;
            money -= astronautCost;
            SetAstronautText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10Astronaut()
    {
        if (money >= astronautCost * 10)
        {
            for (var i = 0; i < 10; i++)
            {
                BuyAstronaut();
            }
        }
    }

    public void Buy100Astronaut()
    {
        if (money >= astronautCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuyAstronaut();
            }
        }
    }

    public void Buy1000Astronaut()
    {
        if (money >= astronautCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuyAstronaut();
            }
        }
    }

    public void BuyVan()
    {
        if (money >= vanCost)
        {
            vanCount += 1;
            vanStatCounter += 1;
            money -= vanCost;
            SetVanText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyParlour()
    {
        if (money >= parlourCost)
        {
            parlourCount += 1;
            parlourStatCounter += 1;
            money -= parlourCost;
            SetParlourText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyRestaurant()
    {
        if (money >= restaurantCost)
        {
            restaurantCount += 1;
            restaurantStatCounter += 1;
            money -= restaurantCost;
            SetRestaurantText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyPalace()
    {
        if (money >= palaceCost)
        {
            palaceCount += 1;
            palaceStatCounter += 1;
            money -= palaceCost;
            SetPalaceText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyFactory()
    {
        if (money >= factoryCost)
        {
            factoryCount += 1;
            factoryStatCounter += 1;
            money -= factoryCost;
            SetFactoryText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyConverter()
    {
        if (money >= converterCost)
        {
            converterCount += 1;
            converterStatCounter += 1;
            money -= converterCost;
            SetConverterText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyScrapMetal()
    {
        if (money >= scrapMetalCost)
        {
            scrapMetalCount += 1;
            scrapMetalStatCounter += 1;
            money -= scrapMetalCost;
            SetScrapMetalText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void Buy10ScrapMetal()
    {
        if (money >= scrapMetalCost * 10)
        {
            for (var i = 0; i < 10; i++)
            {
                BuyScrapMetal();
            }
        }
    }

    public void Buy100ScrapMetal()
    {
        if (money >= scrapMetalCost * 100)
        {
            for (var i = 0; i < 100; i++)
            {
                BuyScrapMetal();
            }
        }
    }

    public void Buy1000ScrapMetal()
    {
        if (money >= scrapMetalCost * 1000)
        {
            for (var i = 0; i < 1000; i++)
            {
                BuyScrapMetal();
            }
        }
    }


    public void BuyWeatherMachine()
    {
        if (money >= weatherMachineCost)
        {
            weatherMachineCount += 1;
            weatherMachineStatCounter += 1;
            money -= weatherMachineCost;
            SetWeatherMachineText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuySuperDrill()
    {
        if (money >= superDrillCost)
        {
            superDrillCount += 1;
            superDrillStatCounter += 1;
            money -= superDrillCost;
            SetSuperDrillText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuySpaceElevator()
    {
        if (money >= spaceElevatorCost)
        {
            spaceElevatorCount += 1;
            spaceElevatorStatCounter += 1;
            money -= spaceElevatorCost;
            SetSpaceElevatorText();
            SetMoneyText();
            UpdateStats();
        }
    }

    public void BuyMoonBase()
    {
        if (money >= moonBaseCost)
        {
            moonBaseCount += 1;
            moonBaseStatCounter += 1;
            money -= moonBaseCost;
            SetMoonBaseText();
            SetMoneyText();
            UpdateStats();
        }
    }

    /// <summary>
    /// Buy functions for upgrades
    /// </summary>

    public void BuyAutoClicker()
    {
        if (money >= autoClickerCost)
        {
            autoClickerCount += 1;
            money -= autoClickerCost;
            SetAutoClickerText();
            SetMoneyText();
            autoClickerButton.SetActive(false);
        }
    }

    public void BuyConvientClickingOne()
    {
        if (money >= convenientClickingOneCost)
        {
            convenientClickingCount += 1;
            slaveMultiBuyButtons.SetActive(true);
            cleanerMultiBuyButtons.SetActive(true);
            managerMultiBuyButtons.SetActive(true);
            money -= convenientClickingOneCost;
            SetConvenientClickingOneText();
            SetMoneyText();
            convenientClickingOneButton.SetActive(false);
        }
    }

    public void BuyConvientClickingTwo()
    {
        if (money >= convenientClickingTwoCost)
        {
            convenientClickingCount += 1;
            operatorMultiBuyButtons.SetActive(true);
            scientistMultiBuyButtons.SetActive(true);
            scrapMetalMultiBuyButtons.SetActive(true);
            money -= convenientClickingTwoCost;
            SetConvenientClickingTwoText();
            SetMoneyText();
            convenientClickingTwoButton.SetActive(false);
        }
    }

    public void BuyConvientClickingThree()
    {
        if (money >= convenientClickingThreeCost)
        {
            convenientClickingCount += 1;
            astronautMultiBuyButtons.SetActive(true);
            money -= convenientClickingThreeCost;
            SetConvenientClickingThreeText();
            SetMoneyText();
            convenientClickingThreeButton.SetActive(false);
        }
    }

    public void UseTwoHands()
    {
        if(money >= useTwoHandsCost)
        {
            clickMultiplierCount += 1;
            money -= useTwoHandsCost;
            SetUseTwoHandsText();
            SetMoneyText();
            useTwoHandsButton.SetActive(false);
            useLegsButton.SetActive(true);
        }
    }

    public void UseLegs()
    {
        if (money >= useLegsCost)
        {
            clickMultiplierCount += 1;
            money -= useLegsCost;
            SetUseLegsText();
            SetMoneyText();
            useLegsButton.SetActive(false);
            growCloneButton.SetActive(true);
        }
    }

    public void GrowClone()
    {
        if (money >= growCloneCost)
        {
            clickMultiplierCount += 1;
            money -= growCloneCost;
            SetGrowCloneText();
            SetMoneyText();
            growCloneButton.SetActive(false);
            bodyModificationButton.SetActive(true);
        }
    }

    public void BuyBodyMod()
    {
        if (money >= bodyModificationCost)
        {
            clickMultiplierCount += 1;
            money -= bodyModificationCost;
            SetBodyModificationText();
            SetMoneyText();
            bodyModificationButton.SetActive(false);
        }
    }

    public void BuyPepperoni()
    {
        if (money >= pepperoniCost)
        {
            priceMultiplierCount += 1;
            money -= pepperoniCost;
            SetPepperoniText();
            SetMoneyText();
            pepperoniButton.SetActive(false);
            chickenButton.SetActive(true);
        }
    }

    public void BuyChicken()
    {
        if (money >= chickenCost)
        {
            priceMultiplierCount += 1;
            money -= chickenCost;
            SetChickenText();
            SetMoneyText();
            chickenButton.SetActive(false);
            groundBeefButton.SetActive(true);
        }
    }

    public void BuyGroundBeef()
    {
        if (money >= groundBeefCost)
        {
            priceMultiplierCount += 1;
            money -= groundBeefCost;
            SetGroundBeefText();
            SetMoneyText();
            groundBeefButton.SetActive(false);
            sausageButton.SetActive(true);
        }
    }

    public void BuySausage()
    {
        if (money >= sausageCost)
        {
            priceMultiplierCount += 1;
            money -= sausageCost;
            SetSausageText();
            SetMoneyText();
            sausageButton.SetActive(false);
        }
    }

    /// <summary>
    /// Main Quest button functions
    /// </summary>

    public void BuildRocket()
    {
        if (money >= 100000000000)
        {
            rocketCount += 1;
            money -= 100000000000;
            rocketButton.interactable = false;

            if (rocketCount == 1 && crewCount == 1 && fuelCount == 1)
            {
                marsTravelButton.SetActive(true);
            }
        }
    }

    public void SupplyCrew()
    {
        if (astronautCount >= 5000 && scientistCount >= 5000)
        {
            crewCount += 1;
            astronautCount -= 5000;
            scientistCount -= 5000;
            crewButton.interactable = false;

            if (rocketCount == 1 && crewCount == 1 && fuelCount == 1)
            {
                marsTravelButton.SetActive(true);
            }
        }
    }

    public void DonateFuel()
    {
        if (pizzas >= 10000000000)
        {
            fuelCount += 1;
            pizzas -= 100000000000;
            fuelButton.interactable = false;

            if (rocketCount == 1 && crewCount == 1 && fuelCount == 1)
            {
                marsTravelButton.SetActive(true);
            }
        }
    }

    /// <summary>
    /// Shipment functions for other planets
    /// </summary>

    public void SendFoodShipment()
    {
        if(money >= 200000)
        {
            GameObject marsinterface = GameObject.Find("MarsInterface");
            MarsController mif = marsinterface.GetComponent<MarsController>();

            mif.food += 1000;
        }
    }



}
