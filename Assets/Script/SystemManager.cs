using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class SystemManager : MonoBehaviour
{

    public TMP_Text systemTime;

  
    // Update is called once per frame
    void Update()
    {
        systemTime.text = DateTime.Now.ToString();
    }
}
