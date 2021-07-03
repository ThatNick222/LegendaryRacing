using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UpCountWatch : MonoBehaviour
{
public static bool stopwatchActive = false;
float currentTime;
public Text CurrentTimeText;
public Text AllTime;
    // Start is called before the first frame update
    void Start()
    {
          currentTime = 0;
         
    }

    // Update is called once per frame
    void Update()
    {
        if(stopwatchActive == true)
        {
             currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        CurrentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        AllTime.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        
    }
   



    
}
