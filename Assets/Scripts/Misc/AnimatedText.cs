using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedText : MonoBehaviour
{
    public float letterPause = 0.1f;
    public Text guiText;

    string message;

    // Use this for initialization
    void Start()
    {
        message = guiText.text;
        guiText.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            guiText.text += letter;
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }

}
