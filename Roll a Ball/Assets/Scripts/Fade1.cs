﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade1 : MonoBehaviour
{
    //Attach an Image you want to fade in the GameObject's Inspector
    public Text text;
    //Use this to tell if the toggle returns true or false
    bool m_Fading;

    void Start()
    {
        StartCoroutine(FaderPic());
    }

    IEnumerator FaderPic()
    {
        yield return new WaitForSeconds(3);
        //If the toggle returns true, fade in the Image
        if (m_Fading == true)
        {
            //Fully fade in Image (1) with the duration of 2
            text.CrossFadeAlpha(1, 4.0f, false);
        }
        //If the toggle is false, fade out to nothing (0) the Image with a duration of 2
        if (m_Fading == false)
        {
            text.CrossFadeAlpha(0, 4.0f, false);
        }
    }

    void OnGUI()
    {
        //Fetch the Toggle's state
        m_Fading = GUI.Toggle(new Rect(0, 0, 100, 30), m_Fading, "Fade In/Out");
    }
}