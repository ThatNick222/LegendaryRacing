using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoseColour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Yello()
    {
       GetComponent<Renderer>().material.color = Color.yellow;
       SceneManager.LoadScene("CarbonFibre");
    }


    // Update is called once per frame
    void Update()
    {
    
        {

        }
    }
}
