using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioButton : MonoBehaviour
{
    private string currentDifficulty = "Easy";
    private Toggle toggleEasy;
    private Toggle toggleMedium;
    private Toggle toggleHard;
    // Start is called before the first frame update
    void Start()
    {
        toggleEasy = transform.Find("Toggle-easy").GetComponent<Toggle>();
        toggleMedium = transform.Find("Toggle-medium").GetComponent<Toggle>();
        toggleHard = transform.Find("Toggle-hard").GetComponent<Toggle>();
    }

    // Update is called once per frame
    public void PrintNewGroupValue(Toggle sender)
    {
        if (sender.isOn)
        {
            currentDifficulty = sender.tag;
            print("option changed to = " + currentDifficulty);

            //jika sender easy, maka hard dan medium mati
            if (sender.tag == "Easy")
            {
                toggleMedium.isOn = false;
                toggleHard.isOn = false;
            }

            else if (sender.tag == "Medium")
            {
                toggleEasy.isOn = false;
                toggleHard.isOn = false;
            }

            else if (sender.tag == "Hard")
            {
                toggleEasy.isOn = false;
                toggleMedium.isOn = false;
            }
        }
    }
}
