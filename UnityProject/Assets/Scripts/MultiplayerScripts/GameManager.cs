using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourPunCallbacks
{
   public GameObject ChoosePanel;
    // Start is called before the first frame update
    void Start()
    {
        
       ChoosePanel.SetActive(true);
            // PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);

        
    }
    public void Evolution()
    {
        PhotonNetwork.Instantiate("MitsubishiEvo", Vector3.zero, Quaternion.identity);
        ChoosePanel.SetActive(false);
    }
    public void Camaro()
    {
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity);
        ChoosePanel.SetActive(false);
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
