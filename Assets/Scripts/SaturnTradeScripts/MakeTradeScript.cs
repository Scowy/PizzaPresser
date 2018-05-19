using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTradeScript : MonoBehaviour
{
    public Button tradeButton;
    public float gold;
    public Text goldDifferenceText;

    private InventoryScript shopInventoryItems;// = GameObject.FindGameObjectWithTag("ShopInv").GetComponent<InventoryScript>();
    private InventoryScript userInventoryItems;// = GameObject.FindGameObjectWithTag("UserInv").GetComponent<InventoryScript>();
    private TradeScript shopTradeItems;// = GameObject.FindGameObjectWithTag("ShopTrade").GetComponent<TradeScript>();
    private TradeScript userTradeItems;// = GameObject.FindGameObjectWithTag("UserTrade").GetComponent<TradeScript>();
    private float goldDifference;

    void Start()
    {
        shopInventoryItems = GameObject.FindGameObjectWithTag("ShopInv").GetComponent<InventoryScript>();
        userInventoryItems = GameObject.FindGameObjectWithTag("UserInv").GetComponent<InventoryScript>();
        shopTradeItems = GameObject.FindGameObjectWithTag("ShopTrade").GetComponent<TradeScript>();
        userTradeItems = GameObject.FindGameObjectWithTag("UserTrade").GetComponent<TradeScript>();
    }

    void Update()
    {
        TradeMoneyValue();
    }

    public void AddItemsToInventory()
    {
        if (userInventoryItems.gold >= shopTradeItems.itemValue - userTradeItems.itemValue && shopInventoryItems.gold >= userTradeItems.itemValue - shopTradeItems.itemValue)
        {
            userInventoryItems.gold += userTradeItems.itemValue - shopTradeItems.itemValue;
            shopInventoryItems.gold += shopTradeItems.itemValue - userTradeItems.itemValue;

            userInventoryItems.AddItems(userTradeItems, shopInventoryItems);
            userInventoryItems.AddItems(shopTradeItems, userInventoryItems);
            userTradeItems.RemoveItems(shopTradeItems);
            shopTradeItems.RemoveItems(userTradeItems);

            shopInventoryItems.RefreshDisplay();
            userInventoryItems.RefreshDisplay();
            shopTradeItems.RefreshDisplay();
            userTradeItems.RefreshDisplay();
        }
    }

    void TradeMoneyValue()
    {
        goldDifference = userTradeItems.itemValue - shopTradeItems.itemValue;
        if (goldDifference >= 0)
        {
            goldDifferenceText.text = "+" + goldDifference.ToString("f0");
        }
        else
        {
            goldDifferenceText.text = goldDifference.ToString("f0");
        }
        
    }
}
