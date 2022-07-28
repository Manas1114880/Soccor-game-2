
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    public ScoreIncrement scoreResults = new ScoreIncrement();// Creating an object for the 

    private void OnTriggerEnter(Collider other){//If the ball detects one of the triggers with assigned tags
        if(other.gameObject.tag == "Goal1"){
            scoreResults.scoreIncrementation1();//If the tag name is "Goal1", it will call the method form the object to increment team1's score
        }
        else if(other.gameObject.tag == "Goal2"){
            scoreResults.scoreIncrementation2();//If "Goal2", then increments team2's score
        }
    }
}
