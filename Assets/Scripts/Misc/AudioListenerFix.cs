using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioListenerFix : MonoBehaviour
{
    public static AudioListenerFix audio;

    private void Awake()
    {
        if (audio == null)
        {
            DontDestroyOnLoad(gameObject);
            audio = this;
        }
        else if (audio != this)
        {
            Destroy(gameObject);
        }
    }
}
