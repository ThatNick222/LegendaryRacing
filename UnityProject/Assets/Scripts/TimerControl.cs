﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerControl : MonoBehaviour
{
    public float timer = 110f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<Text>().text = "Time left";
       timer -= Time.deltaTime;
       timerSeconds.text = timer.ToString("F0");
       if (timer <= 0)
       {
           SceneManager.LoadScene("Lose");
       }
    }
}
