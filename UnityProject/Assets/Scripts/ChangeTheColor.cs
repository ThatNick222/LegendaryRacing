using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTheColor : MonoBehaviour
{
    public GameObject Player;
    Color color;
  
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("BodyColor") == "yellow")
        {
            color = Color.yellow;
        }
        Player.GetComponent<Renderer>().material.color=color;
        if(PlayerPrefs.GetString("BodyColor") == "blue")
        {
            color = Color.blue;
        }
        Player.GetComponent<Renderer>().material.color=color;
        if(PlayerPrefs.GetString("BodyColor") == "black")
        {
            color = Color.black;
        }
        Player.GetComponent<Renderer>().material.color=color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
