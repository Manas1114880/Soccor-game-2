using System.Collections;
using System.Collections.Generic;
using System.IO;
using Photon.Pun;
using UnityEngine;


public class PhotonManager : MonoBehaviour
{

    [SerializeField] GameObject[] SpawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsConnected){
            SpawnPlayer();
        }
    }

    void SpawnPlayer(){
        int player = 0;
        if(!PhotonNetwork.IsMasterClient){
            player = 1;
        }
        GameObject Player = PhotonNetwork.Instantiate("Player", SpawnPoints[player].transform.pos());
    }
}
