using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SaturnInventoryButtonScript : MonoBehaviour, IPointerUpHandler
{
    public Button buttonComponent;
    public Text nameLabel;
    public Text amountText;
    public GameObject sellAmountPanel;
    public Slider sellAmountSlider;
    public Text sellAmountText;

    private ItemScript item;
    private InventoryScript scrollList;
    private Transform contentPanel;

    public void Setup(ItemScript currentItem, InventoryScript currentScrollList)
    {
        item = currentItem;
        nameLabel.text = item.itemName;
        amountText.text = "x" + item.amount.ToString();
        scrollList = currentScrollList;
    }

    private void Update()
    {
        sellAmountText.text = sellAmountSlider.value.ToString();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (buttonComponent.interactable == true)
        {
            bool isShiftKeyDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);

            if (sellAmountPanel.activeInHierarchy == false)
            {
                if (isShiftKeyDown == true)
                {
                    SellAmountPanelRefresh();
                    sellAmountPanel.SetActive(true);

                    contentPanel = transform.parent;

                    for (int i = 0; i < contentPanel.childCount; i++)
                    {
                        if (scrollList.itemList[i].itemName != item.itemName)
                        {
                            contentPanel.GetChild(i).gameObject.GetComponent<Button>().interactable = false;
                        }
                    }
                }
                if (isShiftKeyDown == false)
                {
                    scrollList.TryTransferItemToOtherShop(item);
                }
            }
        }

    }

    void SellAmountPanelRefresh()
    {
        sellAmountSlider.minValue = 1;
        sellAmountSlider.maxValue = item.amount;
        sellAmountSlider.value = item.amount / 2;
    }

    public void Sell()
    {
        scrollList.otherShop.itemList.Add(new ItemScript(item.itemName, sellAmountSlider.value, item.price));
        item.amount = item.amount - sellAmountSlider.value;

        sellAmountPanel.SetActive(false);

        contentPanel = transform.parent;

        for (int i = 0; i < contentPanel.childCount; i++)
        {
            if (scrollList.itemList[i].itemName != item.itemName)
            {
                contentPanel.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
            }
        }

        scrollList.RefreshDisplay();
        scrollList.otherShop.RefreshDisplay();
    }

    public void IncreaseSlider()
    {
        sellAmountSlider.value += 1;
    }

    public void DecreaseSlider()
    {
        sellAmountSlider.value -= 1;
    }
}
