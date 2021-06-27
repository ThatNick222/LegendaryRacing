using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class InfoPlayer : MonoBehaviour
{
     public static class InfoPlayerr
    {
        public static string nickname = "Name";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
 public void OnApplicationQuit()
    {
        if (GetComponent<PhotonView>().IsMine)
        {
            string nick = GetComponent<PhotonView>().Owner.NickName;
            PlayerPrefs.SetString("Nickname", nick);

        }
    }
    
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
