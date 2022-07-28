
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncrement : MonoBehaviour
{
    private bool MatchActive1 = true;
    private bool MatchActive2 = true;
    private int Score1 = 0;
    private int Score2 = 0;
    public Text scoreText1;
    public Text scoreText2;

    void Start()
    {

    }

    public void scoreIncrementation1(){
        if(MatchActive1){//When this is true, it will increment score 1 and change the text in the UI
            Score1++;
            scoreText1.text = "Team 1 Score: " + Score1.ToString();
        }
    }
    public void scoreIncrementation2(){
        if(MatchActive2){
            Score2++;
            scoreText2.text = "Team 2 Score: " + Score2.ToString();
        }
    }

    void Update()
    {
        
    }
}
