using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaClickEffectScript : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        GameObject earthinterface = GameObject.Find("EarthInterface");
        EarthController eif = earthinterface.GetComponent<EarthController>();

        animator.SetBool("goRight", eif.goRight);
    }
}
