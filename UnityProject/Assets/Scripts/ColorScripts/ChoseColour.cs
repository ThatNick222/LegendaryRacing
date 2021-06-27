using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoseColour : MonoBehaviour
{
   
    Color color;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }
    public void SaveColor(string color)
    {
        PlayerPrefs.SetString("BodyColor", color);
    }

   


    // Update is called once per frame
  
}
