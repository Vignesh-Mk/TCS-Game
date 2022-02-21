using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public Text ScoreText;
    public Text TimerDown;

   

    public static int TargetsReached;
    public static int TotalTargets = 11;
    public static float TimeOut = 50;
    public static float CurrentTime;

    // Start is called before the first frame update
    void Start()
    {
        
        Targets.IsPlayable = true;
        TargetsReached = 0;
        CurrentTime = TimeOut;
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        ScoreText.text = TargetsReached.ToString() + "/11";
        

        if(CurrentTime <= 0)
        {
            TimerDown.text = "0 Secs left!!";
            Targets.IsPlayable = false;

            
        }

        else
        {
            TimerDown.text = CurrentTime.ToString() + "secs left!";

            
        }
    }
}
