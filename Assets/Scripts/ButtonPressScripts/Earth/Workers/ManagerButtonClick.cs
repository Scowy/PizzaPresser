﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ManagerButtonClick : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();
        eif.BuyManager();
    }
}
