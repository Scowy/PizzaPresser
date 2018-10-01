using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthEventScript : MonoBehaviour
{
    public Transform earthInterface;

    private float triggerScore;
    public float eventTime;

    private bool pizzaLeakageActive;
    public GameObject leakedPizzaPrefab;
    public float pizzaTotal;
    private float n;

    public bool breakDownActive;
    public GameObject breakDownPanel;
    public GameObject breakDownButton;
    public Slider breakDownSlider;
    public int b;

    void Start()
    {
        EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();

        triggerScore = 0;
        n = 5f;
        b = 1;
        pizzaLeakageActive = false;
        breakDownActive = false;
    }

    void Update()
    {
        triggerScore += Time.deltaTime * eventTime;

        if (triggerScore >= 1000)
        {
            float i = Random.Range(0, 1);

            if (i < 0.5)
            {
                if(i < 0.2 && i >= 0.1)
                {
                    BreakDown();
                }

                if (i < 0.1)
                {
                    PizzaLeakage();
                }
            }
        }

        if (pizzaLeakageActive == true)
        {
            float leakedPizzaCounter = 0;
            n -= Time.deltaTime;

            if (n <= 0)
            {
                Instantiate(leakedPizzaPrefab, new Vector3(Random.Range(300f, 900f), 1200f, 0f), Quaternion.Euler(new Vector3(0, 0, 0)), earthInterface);
                leakedPizzaCounter += 1;
                n = 2f - 0.075f * leakedPizzaCounter;
            }

            if (leakedPizzaCounter >= 20)
            {
                pizzaLeakageActive = false;
                leakedPizzaCounter = 0;
                n = 2f;
            }
        }

        if (breakDownActive == true)
        {
            if (b < 20)
            {
                for (int t = b; t <= 20; t++)
                {
                    GameObject clone = Instantiate(breakDownButton, new Vector3(Random.Range(-400f, 400f), Random.Range(-400f, 400f), 0f), Quaternion.Euler(new Vector3(0, 0, 0)));
                    clone.transform.SetParent(breakDownPanel.transform, false);
                    b = t;
                }
            }
            if (breakDownSlider.value >= breakDownSlider.maxValue)
            {
                breakDownActive = false;
                breakDownPanel.SetActive(false);
            }
            EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();
            eif.pizzas -= eif.pizzasPerSecond * Time.deltaTime;
        }
    }

    public void PizzaLeakage()
    {
        EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();

        pizzaTotal = eif.pizzasPerSecond * 100;
        pizzaLeakageActive = true;
    }

    public void BreakDown()
    {
        EarthController eif = GameObject.Find("EarthInterface").GetComponent<EarthController>();

        breakDownActive = true;
        breakDownPanel.SetActive(true);
    }
}