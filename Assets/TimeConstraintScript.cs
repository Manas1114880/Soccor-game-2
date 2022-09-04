
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeConstraintScript : MonoBehaviour
{
    public Text TimeText;
    public int MatchTime;
    public string sceneName;
    private float startTime = 0;
    //private bool timerRunning;
    

    void Start()
    {
        //timeCountingDown = MatchTime - Time.time;
        SetTimeDisplay(MatchTime);
        startTime = Time.time;
    }

    void Update()
    {
        Debug.Log(startTime);
            if (Time.time - startTime < MatchTime)
            {
                SetTimeDisplay(MatchTime - (Time.time - startTime));//Stuff inside perenthesis makes sure the time counts down
            }
            else
            {
            //If time reaches 0 and you havent scores 3 goals, then it restarts the level
            //timeCountingDown = MatchTime;
                SetTimeDisplay(0);
                SceneManager.LoadScene("Soccor Game(Photon)");
            }
    }
    
    private void SetTimeDisplay(float TimeDisplay)
    {
        TimeText.text = GetTimeDisplay(TimeDisplay);
    }

    private string GetTimeDisplay(float TimeShown)
    {
        int SecondsShown = Mathf.CeilToInt(TimeShown);
        int Sec = SecondsShown % 60;
        string secDisplay = (Sec < 10) ? "0" + Sec.ToString() : Sec.ToString();//This is basically a way to assign a variable to an if conditional
        int Mins = (SecondsShown - Sec) / 60;
        return Mins.ToString() + ":" + secDisplay;// Returns the text of the time
    }
}
