using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MartianSoldierButtonClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject marsinterface = GameObject.Find("MarsInterface");
        MarsController mif = marsinterface.GetComponent<MarsController>();
        mif.BuyMartianSoldier();
    }
}
