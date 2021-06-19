using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStart()
    {
        SceneManager.LoadScene("GameMain");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Blue()
    {
        SceneManager.LoadScene("BlueCar");
    }
    public void Yellow()
    {
        SceneManager.LoadScene("GameMain");
    }
    public void Black()
    {
        SceneManager.LoadScene("CarbonFibre");
    }
    public void NextOne()
    {
        SceneManager.LoadScene("Explanation");
    }
    public void Next()
    {
        SceneManager.LoadScene("Info");
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Won");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
