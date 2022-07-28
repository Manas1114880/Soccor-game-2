
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//This file is responsible for the players motion
public class PlayerMotion : MonoBehaviour
{

 //Executes code for every other frame
    public void Update(){
      double speed = 0.5;
      float xDirection = (float)speed*Input.GetAxis("Horizontal");
      float zDirection = (float)speed*Input.GetAxis("Vertical");
      this.transform.Translate(xDirection , 0.0f, zDirection);

    }
}
