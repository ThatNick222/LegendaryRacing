using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneAll : MonoBehaviour
{
  //   public GameObject Mitsubishi;
   // public GameObject Evo;
    // Start is called before the first frame update
   public void StartGame()
   {
       SceneManager.LoadScene("Explanation");
   }
   public void PickColor()
   {
       SceneManager.LoadScene("Info");
   }
   public void multiplayer()
   {
       SceneManager.LoadScene("InstructionsMult");
   }
   public void StartMultiplayer()
   {
        SceneManager.LoadScene("Entrance");
        InfoPlayer.InfoPlayerr.nickname = GameObject.FindObjectOfType<InputField>().text;
   }
   public void OpenRules()
   {
       SceneManager.LoadScene("AboutGame");
   }
  
   public void ReadTheRules()
   {
       SceneManager.LoadScene("Start");
   }
  public void Exit()
  {
      Application.Quit();
  }
 
 // public void Mitsubishie()
 
     //   GameManager.PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
      //  Mitsubishi = Evo;
      //  SceneManager.LoadScene("Entrance");


   
}
