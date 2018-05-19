using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

[System.Serializable]
public class ItemScript
{
    public string itemName;
    public float amount;
    public float price;


    public ItemScript(string newItemName, float newAmount, float newPrice)
    {
        itemName = newItemName;
        amount = newAmount;
        price = newPrice;
    }
}
