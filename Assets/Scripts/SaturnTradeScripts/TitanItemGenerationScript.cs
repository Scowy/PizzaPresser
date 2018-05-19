using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitanItemGenerationScript : MonoBehaviour
{
    private InventoryScript shopList;

    void Start()
    {
        shopList = GetComponent<InventoryScript>();

        shopList.itemList.Add(new ItemScript("Titanium", 2000, 150));
        shopList.itemList.Add(new ItemScript("Coal", 1200, 5));

        shopList.itemList.Add(new ItemScript("Silver", 500, 1000));
        shopList.itemList.Add(new ItemScript("Aluminium", 500, 20));
        shopList.itemList.Add(new ItemScript("Uranium", 500, 10000));
        shopList.itemList.Add(new ItemScript("Copper", 500, 70));
        shopList.itemList.Add(new ItemScript("Helium", 500, 80));
        shopList.itemList.Add(new ItemScript("Lead", 500, 20));
        shopList.itemList.Add(new ItemScript("Iron", 500, 1));
        shopList.itemList.Add(new ItemScript("Magnesium", 500, 50));
        shopList.itemList.Add(new ItemScript("Phosphorous", 500, 300));
        shopList.itemList.Add(new ItemScript("Iridium", 500, 500));
        shopList.itemList.Add(new ItemScript("Mercury", 500, 150));
        shopList.itemList.Add(new ItemScript("Diamond", 500, 1000));
        shopList.itemList.Add(new ItemScript("Silicon", 500, 30));
        shopList.itemList.Add(new ItemScript("Tin", 500, 100));
        shopList.itemList.Add(new ItemScript("Oil", 500, 5));
        shopList.RefreshDisplay();
    }

    private void GenerateItems()
    {

    }
}
