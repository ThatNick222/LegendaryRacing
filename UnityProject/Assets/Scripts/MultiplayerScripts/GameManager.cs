using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourPunCallbacks
{
   public GameObject ChoosePanel;
   public GameObject EvoSpecss;
    // Start is called before the first frame update
    void Start()
    {
        
       ChoosePanel.SetActive(true);
            // PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);

        
    }
    
    public void Evolution()
    {
        PhotonNetwork.Instantiate("Evo", Vector3.zero, Quaternion.identity);
        ChoosePanel.SetActive(false);
    }
    public void Camaro()
    {
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
        ChoosePanel.SetActive(false);
    }
public void Nissan()
{
    PhotonNetwork.Instantiate("Nissan", Vector3.zero, Quaternion.identity);
    ChoosePanel.SetActive(false);
}


 public void EvoSpecs()
   {
       EvoSpecss.SetActive(true);
   }
   public void CloseESpecs()
   {
       EvoSpecss.SetActive(false);
   }


 // PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
//  public void Mitsubishie()
 
 //   Mitsubishi = Evo;
 //   SceneManager.LoadScene("Entrance");
 
    // Update is called once per frame
    void Update()
    {
        
    }
}
