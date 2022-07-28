
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPun
{

    private CharactarController controller;
    private Vector3 vectorVelocity;
    private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 10.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    private float gravity = 9.81f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
