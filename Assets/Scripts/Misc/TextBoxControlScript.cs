using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxControlScript : MonoBehaviour
{
    public Animator anim;

    public void Expand(bool newValue)
    {
        anim.SetBool("Expand", newValue);
    }

    public void Retract()
    {
        anim.SetBool("Expand", false);
    }
}
