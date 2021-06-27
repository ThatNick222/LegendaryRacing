using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSpeed : MonoBehaviour
{
public Text speedometer;
    // Start is called before the first frame update
    void Start()
    {
        speedometer = GameObject.Find("Canvas/Speedometer").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        float speed = GetComponent<Rigidbody>().velocity.magnitude;
        speedometer.text = speed.ToString();
    }
}
