using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour {

    public Slider mySlider;

    // Use this for initialization
    public void OnValueChanged()
    {
        AudioListener.volume = mySlider.value;
    }
}
