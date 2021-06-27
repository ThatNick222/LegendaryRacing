using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EntranceManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.NickName = InfoPlayer.InfoPlayerr.nickname;

       // if(InfoPlayer.InfoPlayerr.nickname == "")
      //  PhotonNetwork.NickName = "Player_" + Random.Range(1000, 9999);
      //  PhotonNetwork.NickName = "Player";
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.ConnectUsingSettings();



    }
    public override void OnConnectedToMaster()
    {
        if (PhotonNetwork.CountOfRooms > 0)
        {
            PhotonNetwork.JoinRoom("Unity");
            Debug.Log("Joining room unity");
        }
        else
        {
            PhotonNetwork.CreateRoom("Unity");
            Debug.Log("Created a new room, joining now");
        }
    }
   // public override void OnCreatedRoom()
   // {
    //    PhotonNetwork.JoinRoom("Unity");
  //  }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GameM");
        Debug.Log("You are in");
    }

    
    
   

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
