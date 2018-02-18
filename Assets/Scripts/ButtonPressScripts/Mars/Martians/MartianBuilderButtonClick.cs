using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MartianBuilderButtonClick : MonoBehaviour, IPointerDownHandler
{
    public GameObject marsInterface;

    public void OnPointerDown(PointerEventData eventData)
    {
        MarsController mif = marsInterface.GetComponent<MarsController>();
        mif.BuyMartianBuilder();
    }
}
