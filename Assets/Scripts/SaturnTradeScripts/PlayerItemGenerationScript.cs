using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerItemGenerationScript : MonoBehaviour
{
    private InventoryScript shopList;

    void Start()
    {
        shopList = GetComponent<InventoryScript>();

        shopList.itemList.Add(new ItemScript("Silver", 100, 5));
        shopList.itemList.Add(new ItemScript("Aluminium", 100, 2));
        shopList.itemList.Add(new ItemScript("Copper", 100, 3));
        shopList.itemList.Add(new ItemScript("Gold", 100, 10));
        shopList.RefreshDisplay();
    }
}
