using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraConrols : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<Camera>().enabled = GetComponentInParent<PhotonView>().IsMine;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
