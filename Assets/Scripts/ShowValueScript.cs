using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowValueScript : MonoBehaviour
{
    Text slideText;

    // Start
    void Start()
    {
        slideText = GetComponent<Text>();
    }

    void textUpdate(float value)
    {
        slideText.text = "Difficulty: " + Mathf.RoundToInt(value * 100) + "%";
    }


    
    // public Slider diffSlider;
    // public float slideValue;
    // private string sceneName;

    /* Update
    void OnValueChanged(float newValue)
    {
        slideValue = newValue;
        Debug.Log(diffSlider.slideValue);
    }*/


}
