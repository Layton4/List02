using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exercice2Timer : MonoBehaviour
{
    public float time = 10; //Counter of time in realtime
    public float maxTime; //the time of the begining 
    public TextMeshProUGUI timerNumber; //number on screen of the timecouner

    public Image timeBar; //the line bar will disapear whith the time

    //booleans to not click on the start button before it ends the timer
    private bool countTime = false; 
    private bool canClick = true;

    public GameObject ringText; //text to indicates the time is over
    
    void Start()
    {
        timerNumber.text = time.ToString(); //we start showing the default maxtime on screen
    }

    void Update()
    {
        if (countTime && time > 0) //if we have clicked the button and timer is not 0 yet we still reducing the time and the bar
        {
            time -= Time.deltaTime;
            timerNumber.text = Mathf.Round(time).ToString();
            timeBar.fillAmount = time / maxTime;
        }

        if (time <= 0 && countTime) //When the time is over
        {
            canClick = true; //we can click again the button
            countTime = false; //we are not counting
            ringText.SetActive(true); //the text indicates us the time is over
            time = maxTime; //we return the timer to maxtime if he player want to change it before hit again the start button
            timerNumber.text = time.ToString();
        }
    }

    public void MoreTime() //the arrow to add more time to the maxtime
    {
        if(countTime == false)
        {
            time += 1;
            timerNumber.text = time.ToString();
        }
        
    }

    public void LessTime() //the arrow to reduce the maxtime
    {
        if(countTime == false)
        {
            time -= 1;
            timerNumber.text = time.ToString();
        }
    }

    public void StartButton() //the button to start counting the time
    {
        if(canClick == true)
        {
            ringText.SetActive(false);
            countTime = true;
            maxTime = time;
            canClick = false;
        }  
    }
}
