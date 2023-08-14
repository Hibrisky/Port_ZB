using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    public void FadeIn(float fadeOutTime, System.Action nextEvent = null)
    {
        StartCoroutine(CoFadeIn(fadeOutTime, nextEvent));
    }

    public void FadeOut(float fadeOutTime, System.Action nextEvent = null)
    {
        StartCoroutine(CoFadeOut(fadeOutTime, nextEvent));
    }

    IEnumerator CoFadeIn(float fadeOutTime, Action nextEvent)
    {
        Image img = this.gameObject.GetComponent<Image>();
        Color tempColor = img.color;

        while(tempColor.a < 1f)
        {
            tempColor.a += Time.deltaTime / fadeOutTime;
            img.color = tempColor;

            if (tempColor.a >= 1f)
                tempColor.a = 1f;

            yield return null;
        }

        img.color = tempColor;
        if (nextEvent != null)
            nextEvent();
    }



    IEnumerator CoFadeOut(float fadeOutTime, Action nextEvent)
    {
        Image img = this.gameObject.GetComponent<Image>();
        Color tempColor = img.color;

        while(tempColor.a >0f)
        {
            tempColor.a -= Time.deltaTime / fadeOutTime;
            img.color = tempColor;

            if (tempColor.a <= 0f)
                tempColor.a = 0f;
         
            yield return null;
        }

        img.color = tempColor;
        if (nextEvent != null)
            nextEvent();
    }

   
}
