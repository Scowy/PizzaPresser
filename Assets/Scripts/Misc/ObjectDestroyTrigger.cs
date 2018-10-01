using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDestroyTrigger : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    { 
        if(other.gameObject.tag == "LeakedPizza")
        {
            LeakedPizzaScript lps = other.gameObject.GetComponent<LeakedPizzaScript>();
            EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();

            eif.pizzas -= lps.leakedPizzaValue;

            Destroy(other.gameObject);
        }
    }
}
