using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeakedPizzaScript : MonoBehaviour
{
    public float leakedPizzaValue;
    public GameObject leakedPizza;
    public float speed;
    public bool onScreen = true;

    void Start ()
    {
        EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();
        speed = 400f;
	}

    void Awake()
    {
        EarthEventScript ees = GameObject.Find("EarthInterface").GetComponent<EarthEventScript>();
        leakedPizzaValue = ees.pizzaTotal / 100f * 6.5f;
    }
	
	void Update ()
    {
        leakedPizza.transform.Translate(Vector3.down * Time.deltaTime * speed);
	}

    public void LeakedPizzaClick()
    {
        EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();
        eif.pizzas += leakedPizzaValue;
        Destroy(leakedPizza);
    }
}
