using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemFix : MonoBehaviour
{
    public static EventSystemFix eventsystem;

    private void Awake()
    {
        if (eventsystem == null)
        {
            DontDestroyOnLoad(gameObject);
            eventsystem = this;
        }
        else if (eventsystem != this)
        {
            Destroy(gameObject);
        }
    }
}
