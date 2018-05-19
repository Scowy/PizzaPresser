using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TradeScript : MonoBehaviour
{
    public List<ItemScript> itemList;
    public Transform contentPanel;
    public InventoryScript otherShop;
    public Text myItemValueDisplay;
    public float itemValue;
    public GameObject prefab;


    void Start()
    {
        RefreshDisplay();
    }

    public void RefreshDisplay()
    {
        itemValue = 0;

        for (int i = itemList.Count - 1; i >= 0; i--)
        {
            itemValue += itemList[i].price * itemList[i].amount;
        }

        myItemValueDisplay.text = "Item Value: " + itemValue.ToString();
        RemoveButtons();
        AddButtons();
    }

    private void AddButtons()
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            ItemScript item = itemList[i];
            GameObject newButton = Instantiate(prefab, contentPanel);

            SaturnTradeButtonScript sampleButton = newButton.GetComponent<SaturnTradeButtonScript>();
            sampleButton.Setup(item, this);
        }
    }

    public void RemoveButtons()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void TryTransferItemToOtherShop(ItemScript item)
    {
        //gold -= item.price;
        //otherShop.gold += item.price;

        AddItem(item, otherShop);
        RemoveItem(item, this);

        RefreshDisplay();
        otherShop.RefreshDisplay();
    }

    void AddItem(ItemScript itemToAdd, InventoryScript shopList)
    {
        float itemCheck = 0;

        for (int i = shopList.itemList.Count - 1; i >= 0; i--)
        {
            if (shopList.itemList[i].itemName == itemToAdd.itemName)
            {
                shopList.itemList[i].amount += itemToAdd.amount;
                itemCheck = 1;
            }
        }
        if (itemCheck == 0)
        {
            shopList.itemList.Add(itemToAdd);
        }
    }

    public void AddItems(TradeScript tradeList, InventoryScript inventoryList)
    {
        float itemCheck = 0;

        for (int i = tradeList.itemList.Count - 1; i >= 0; i--)
        {
            for (int q = inventoryList.itemList.Count - 1; q >= 0; q--)
            {
                if (inventoryList.itemList[q].itemName == tradeList.itemList[i].itemName)
                {
                    inventoryList.itemList[q].amount += tradeList.itemList[i].amount;
                    itemCheck = 1;
                }
            }
            if (itemCheck == 0)
            {
                inventoryList.itemList.Add(tradeList.itemList[i]);
            }
            itemCheck = 0;
        }
    }

    private void RemoveItem(ItemScript itemToRemove, TradeScript shopList)
    {
        for (int i = shopList.itemList.Count - 1; i >= 0; i--)
        {
            if (shopList.itemList[i] == itemToRemove)
            {
                shopList.itemList.RemoveAt(i);
            }
        }
    }

    public void RemoveItems(TradeScript shopList)
    {
        for (int i = shopList.itemList.Count - 1; i >= 0; i--)
        {
            shopList.itemList.RemoveAt(i);
        }
    }
}
