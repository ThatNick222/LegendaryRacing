using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndBorder : MonoBehaviour
{
    public List<GameObject> finishedCars;
    // Start is called before the first frame update
    void Start()
    {
        finishedCars = new List<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Lose");
        }
        else
        {
            SceneManager.LoadScene("Won");
        }
        finishedCars.Add(other.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
