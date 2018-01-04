using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.iOS;

public class HoverTextScript : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public GameObject childText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        childText.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        childText.SetActive(false);
    }
}
