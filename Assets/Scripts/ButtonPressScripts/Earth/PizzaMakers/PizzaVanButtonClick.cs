﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PizzaVanButtonClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();
        eif.BuyPizzaVan();
    }
}
