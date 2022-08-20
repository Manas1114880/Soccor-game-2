
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkController : MonoBehaviourPunCallbacks
{

    // Start is called before the first frame update
    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();       
    }
    public override void OnConnectedToMaster()
    {
        //Debug.Log("You have been connected to the " + PhotonNetwork.CloudRegion + " server");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
