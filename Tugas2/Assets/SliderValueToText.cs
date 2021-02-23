using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueToText : MonoBehaviour
{
    public Slider sliderUI;
    private Text textSliderValue;

    // Start is called before the first frame update
    void Start()
    {
        textSliderValue = GetComponent<Text>();
        ShowSliderValue();
    }

    // Update is called once per frame
    public void ShowSliderValue()
    {
        string sliderMessage = "Slider Value = " +
        sliderUI.value;
        textSliderValue.text = sliderMessage;
    }
}
