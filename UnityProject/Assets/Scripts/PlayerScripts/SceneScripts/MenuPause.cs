using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour

{
    public GameObject MenuOfPause, ButtonPause;
    // Start is called before the first frame update
    public void GamePaused()
    {
        MenuOfPause.SetActive(true);
        ButtonPause.SetActive(false);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        MenuOfPause.SetActive(false);
        ButtonPause.SetActive(true);
        Time.timeScale = 1;
    }
    public void BackToMain()
    {
        SceneManager.LoadScene("Start");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
