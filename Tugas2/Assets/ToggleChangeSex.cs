﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleChangeSex : MonoBehaviour
{
    private Toggle toggle;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    // Update is called once per frame
    public void PrintNewToggleValue()
    {
        bool status = toggle.isOn;
        print("toggle status = " + status);
    }
}
