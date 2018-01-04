using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class MainController : MonoBehaviour
{
    [System.Serializable]
    class GameData
    {
        public float pizzas;
        public float money;
        public float pizzasPerSecond;
        public float clickMultiplierCount;
        public float priceMultiplierCount;
        public int convenientClickingCount;

        public int workerCount;
        public int pizzaCartCount;
        public int pizzaVanCount;
        public int pizzaParlourCount;
        public int pizzaRestaurantCount;
        public int pizzaPalaceCount;
        public int pizzaFactoryCount;
        public int pizzaConverterCount;
        public int pizzaWeatherMachineCount;
        public int pizzaSuperDrillCount;
        public int pizzaMoonBaseCount;

        public int slaveCount;
        public int cleanerCount;
        public int managerCount;
        public int operatorCount;
        public int scientistCount;
        public int astronautCount;
        public int cartCount;
        public int vanCount;
        public int parlourCount;
        public int restaurantCount;
        public int palaceCount;
        public int factoryCount;
        public int converterCount;
        public int scrapMetalCount;
        public int weatherMachineCount;
        public int superDrillCount;
        public int spaceElevatorCount;
        public int moonBaseCount;

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
    }

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gameData.dat");

        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        GameData data = new GameData();

        data.pizzas = eif.pizzas;
        data.money = eif.money;
        data.pizzasPerSecond = eif.pizzasPerSecond;
        data.clickMultiplierCount = eif.clickMultiplierCount;
        data.priceMultiplierCount = eif.priceMultiplierCount;
        data.convenientClickingCount = eif.convenientClickingCount;

        data.workerCount = eif.workerCount;
        data.pizzaCartCount = eif.pizzaCartCount;
        data.pizzaVanCount = eif.pizzaVanCount;
        data.pizzaParlourCount = eif.pizzaParlourCount;
        data.pizzaRestaurantCount = eif.pizzaRestaurantCount;
        data.pizzaPalaceCount = eif.pizzaPalaceCount;
        data.pizzaFactoryCount = eif.pizzaFactoryCount;
        data.pizzaConverterCount = eif.pizzaConverterCount;
        data.pizzaWeatherMachineCount = eif.pizzaWeatherMachineCount;
        data.pizzaSuperDrillCount = eif.pizzaSuperDrillCount;
        data.pizzaMoonBaseCount = eif.pizzaMoonBaseCount;

        data.slaveCount = eif.slaveCount;
        data.cleanerCount = eif.cleanerCount;
        data.managerCount = eif.managerCount;
        data.operatorCount = eif.operatorCount;
        data.scientistCount = eif.scientistCount;
        data.astronautCount = eif.astronautCount;
        data.cartCount = eif.cartCount;
        data.vanCount = eif.vanCount;
        data.parlourCount = eif.parlourCount;
        data.restaurantCount = eif.restaurantCount;
        data.palaceCount = eif.palaceCount;
        data.factoryCount = eif.factoryCount;
        data.converterCount = eif.converterCount;
        data.scrapMetalCount = eif.scrapMetalCount;
        data.weatherMachineCount = eif.weatherMachineCount;
        data.superDrillCount = eif.superDrillCount;
        data.spaceElevatorCount = eif.spaceElevatorCount;
        data.moonBaseCount = eif.moonBaseCount;

        data.pizzaStatCounter = eif.pizzaStatCounter;
        data.slaveStatCounter = eif.slaveStatCounter;
        data.cleanerStatCounter = eif.cleanerStatCounter;
        data.managerStatCounter = eif.managerStatCounter;
        data.operatorStatCounter = eif.operatorStatCounter;
        data.scientistStatCounter = eif.scientistStatCounter;
        data.astronautStatCounter = eif.astronautStatCounter;
        data.cartStatCounter = eif.cartStatCounter;
        data.vanStatCounter = eif.vanStatCounter;
        data.parlourStatCounter = eif.parlourStatCounter;
        data.restaurantStatCounter = eif.restaurantStatCounter;
        data.palaceStatCounter = eif.palaceStatCounter;
        data.factoryStatCounter = eif.factoryStatCounter;
        data.converterStatCounter = eif.converterStatCounter;
        data.scrapMetalStatCounter = eif.scrapMetalStatCounter;
        data.weatherMachineStatCounter = eif.weatherMachineStatCounter;
        data.superDrillStatCounter = eif.superDrillStatCounter;
        data.spaceElevatorStatCounter = eif.spaceElevatorStatCounter;
        data.moonBaseStatCounter = eif.moonBaseStatCounter;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/gameData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gameData.dat", FileMode.Open);
            GameData data = (GameData)bf.Deserialize(file);
            file.Close();

            GameObject earthinterface = GameObject.Find("EarthInterface");
            EarthController eif = earthinterface.GetComponent<EarthController>();

            eif.pizzas = data.pizzas;
            eif.money = data.money;
            eif.pizzasPerSecond = data.pizzasPerSecond;
            eif.clickMultiplierCount = data.clickMultiplierCount;
            eif.priceMultiplierCount = data.priceMultiplierCount;
            eif.convenientClickingCount = data.convenientClickingCount;

            eif.workerCount = data.workerCount;
            eif.pizzaCartCount = data.pizzaCartCount;
            eif.pizzaVanCount = data.pizzaVanCount;
            eif.pizzaParlourCount = data.pizzaParlourCount;
            eif.pizzaRestaurantCount = data.pizzaRestaurantCount;
            eif.pizzaPalaceCount = data.pizzaPalaceCount;
            eif.pizzaFactoryCount = data.pizzaFactoryCount;
            eif.pizzaConverterCount = data.pizzaConverterCount;
            eif.pizzaWeatherMachineCount = data.pizzaWeatherMachineCount;
            eif.pizzaSuperDrillCount = data.pizzaSuperDrillCount;
            eif.pizzaMoonBaseCount = data.pizzaMoonBaseCount;

            eif.slaveCount = data.slaveCount;
            eif.cleanerCount = data.cleanerCount;
            eif.managerCount = data.managerCount;
            eif.operatorCount = data.operatorCount;
            eif.scientistCount = data.scientistCount;
            eif.astronautCount = data.astronautCount;
            eif.cartCount = data.cartCount;
            eif.vanCount = data.vanCount;
            eif.parlourCount = data.parlourCount;
            eif.restaurantCount = data.restaurantCount;
            eif.palaceCount = data.palaceCount;
            eif.factoryCount = data.factoryCount;
            eif.converterCount = data.converterCount;
            eif.scrapMetalCount = data.scrapMetalCount;
            eif.weatherMachineCount = data.weatherMachineCount;
            eif.superDrillCount = data.superDrillCount;
            eif.spaceElevatorCount = data.spaceElevatorCount;
            eif.moonBaseCount = data.moonBaseCount;

            eif.pizzaStatCounter = data.pizzaStatCounter;
            eif.slaveStatCounter = data.slaveStatCounter;
            eif.cleanerStatCounter = data.cleanerStatCounter;
            eif.managerStatCounter = data.managerStatCounter;
            eif.operatorStatCounter = data.operatorStatCounter;
            eif.scientistStatCounter = data.scientistStatCounter;
            eif.astronautStatCounter = data.astronautStatCounter;
            eif.cartStatCounter = data.cartStatCounter;
            eif.vanStatCounter = data.vanStatCounter;
            eif.parlourStatCounter = data.parlourStatCounter;
            eif.restaurantStatCounter = data.restaurantStatCounter;
            eif.palaceStatCounter = data.palaceStatCounter;
            eif.factoryStatCounter = data.factoryStatCounter;
            eif.converterStatCounter = data.converterStatCounter;
            eif.scrapMetalStatCounter = data.scrapMetalStatCounter;
            eif.weatherMachineStatCounter = data.weatherMachineStatCounter;
            eif.superDrillStatCounter = data.superDrillStatCounter;
            eif.spaceElevatorStatCounter = data.spaceElevatorStatCounter;
            eif.moonBaseStatCounter = data.moonBaseStatCounter;

            eif.UpdatePizzasPerSecond();
            eif.UpdateWorker();
            eif.UpdatePizzaCart();
            eif.UpdatePizzaVan();
            eif.UpdatePizzaParlour();
            eif.UpdatePizzaRestaurant();
            eif.UpdatePizzaPalace();
            eif.UpdatePizzaFactory();
            eif.UpdatePizzaConverter();
            eif.UpdatePizzaWeatherMachine();
            eif.UpdatePizzaSuperDrill();
            eif.UpdatePizzaMoonBase();
            eif.UpdateStats();

            if (eif.workerCount >= 1)
            {
                eif.pizzaCartButton.SetActive(true);
                eif.reagantsPanel.SetActive(true);
                eif.workersPanel.SetActive(true);
            }
            if (eif.pizzaCartCount >= 1)
            {
                eif.pizzaVanButton.SetActive(true);
                eif.vanButton.SetActive(true);
                eif.upgradesPanel.SetActive(true);
                if (eif.autoClickerCount == 0)
                {
                    eif.autoClickerButton.SetActive(true);
                }
            }
            if (eif.pizzaVanCount >= 1)
            {
                eif.pizzaParlourButton.SetActive(true);
                eif.cleanerButton.SetActive(true);
                eif.managerButton.SetActive(true);
                eif.parlourButton.SetActive(true);
            }
            if (eif.pizzaParlourCount >= 1)
            {
                eif.pizzaRestaurantButton.SetActive(true);
                eif.restaurantButton.SetActive(true);
                if (eif.convenientClickingCount == 0)
                {
                    eif.convenientClickingOneButton.SetActive(true);
                }
            }
            if (eif.pizzaRestaurantCount >= 1)
            {
                eif.pizzaPalaceButton.SetActive(true);
                eif.palaceButton.SetActive(true);
            }
            if (eif.pizzaPalaceCount >= 1)
            {
                eif.pizzaFactoryButton.SetActive(true);
                eif.factoryButton.SetActive(true);
            }
            if (eif.pizzaFactoryCount >= 1)
            {
                eif.pizzaConverterButton.SetActive(true);
                eif.converterButton.SetActive(true);
                eif.scrapMetalButton.SetActive(true);
                eif.operatorButton.SetActive(true);
                eif.scientistButton.SetActive(true);
                if (eif.convenientClickingCount == 1)
                {
                    eif.convenientClickingTwoButton.SetActive(true);
                }
            }
            if (eif.pizzaConverterCount >= 1)
            {
                eif.pizzaWeatherMachineButton.SetActive(true);
                eif.weatherMachineButton.SetActive(true);
            }
            if (eif.pizzaWeatherMachineCount >= 1)
            {
                eif.pizzaSuperDrillButton.SetActive(true);
                eif.superDrillButton.SetActive(true);
            }
            if (eif.pizzaSuperDrillCount >= 1)
            {
                eif.pizzaMoonBaseButton.SetActive(true);
                eif.spaceElevatorButton.SetActive(true);
                eif.moonBaseButton.SetActive(true);
                if (eif.convenientClickingCount == 2)
                {
                    eif.convenientClickingThreeButton.SetActive(true);
                }
            }
            if (eif.pizzaRestaurantCount >= 1 && eif.clickMultiplierCount == 0)
            {
                eif.useTwoHandsButton.SetActive(true);
            }
            if (eif.clickMultiplierCount == 1)
            {
                eif.useLegsButton.SetActive(true);
            }
            if (eif.clickMultiplierCount == 2)
            {
                eif.growCloneButton.SetActive(true);
            }
            if (eif.clickMultiplierCount == 3)
            {
                eif.bodyModificationButton.SetActive(true);
            }
            if (eif.pizzaFactoryCount >= 1 && eif.priceMultiplierCount == 0)
            {
                eif.pepperoniButton.SetActive(true);
            }
            if (eif.priceMultiplierCount == 1)
            {
                eif.chickenButton.SetActive(true);
            }
            if (eif.priceMultiplierCount == 2)
            {
                eif.groundBeefButton.SetActive(true);
            }
            if (eif.priceMultiplierCount == 3)
            {
                eif.sausageButton.SetActive(true);
            }
            
            eif.SetPizzaText();
            eif.SetMoneyText();
            eif.SetPizzasPerSecondText();
            eif.SetWorkerText();
            eif.SetCleanerText();
            eif.SetManagerText();
            eif.SetPizzaCartText();
            eif.SetPizzaVanText();
            eif.SetPizzaParlourText();
            eif.SetPizzaRestaurantText();
            eif.SetPizzaPalaceText();
            eif.SetPizzaFactoryText();
            eif.SetPizzaConverterText();
            eif.SetPizzaWeatherMachineText();
            eif.SetPizzaSuperDrillText();
            eif.SetPizzaMoonBaseText();

            eif.SetSlaveText();
            eif.SetCleanerText();
            eif.SetManagerText();
            eif.SetOperatorText();
            eif.SetScientistText();
            eif.SetCartText();
            eif.SetVanText();
            eif.SetParlourText();
            eif.SetRestaurantText();
            eif.SetPalaceText();
            eif.SetFactoryText();
            eif.SetConverterText();
            eif.SetScrapMetalText();
            eif.SetWeatherMachineText();
            eif.SetSuperDrillText();
            eif.SetSpaceElevatorText();
            eif.SetMoonBaseText();
            eif.SetAstronautText();
        }
    }

    public void Quit()
    {
        if (UnityEditor.EditorApplication.isPlaying == true)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }

    }

    
}
