using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercici4_Questions : MonoBehaviour
{
    public TextMeshProUGUI textOption1; //First option text on screen
    public TextMeshProUGUI textOption2; //Second option text on screen

    public string[] Options1; //Array of all the firsts options
    public string[] Option2; //Array of all the seconds options

    public int pcChoosing; //What option took the pc

    //ResultsTexts
    public TextMeshProUGUI successCounterText; //On the resultsPanel the text where the succesCounter apears
    public TextMeshProUGUI mistakesCounterText; //The mistakes Counter

    //Panels
    public GameObject resultsPanel;
    public GameObject questionsPanel;

    //Counters
    private int currentQuestion; //The question from 0 to 9 the player is answering
    private int successAttempts; //Every time the player and the pc choose the same option

    void Start()
    {
        ActiveQuestionsPanel(); //We make sure we are starting the game in the QuestionsPanel and that we are in the first question
    }
    public void PcChoose() //From two options the pc the random number saves which one is chosen
    {
        pcChoosing = Random.Range(0, 2); //The Pc choose option 1 or 2
    }

    public void PlaceOptions() //Changing options, when we answer and we need to go to the next question
    {
     textOption1.text = Options1[currentQuestion];
     textOption2.text = Option2[currentQuestion];
    }

    public void Choosing(int opt) //When we click one option, we see if it's the same option than the pc
    {
        if(opt == pcChoosing) //if we have chosen the same option we add 1 point of success
        {
            successAttempts++;
        }

        if(currentQuestion < 9) //if the answer was not for the last question we can place the next two options on screen
        {
            currentQuestion++;
            PcChoose();
            PlaceOptions();
        }

        if(currentQuestion == 9) //if we have just answered the last question we show the player the results
        {
            ActiveResultsPanel();
        }
        
    }

    public void ActiveResultsPanel() //When we have answered the 10 questions we want to see the result panels
    {
        questionsPanel.SetActive(false);
        resultsPanel.SetActive(true);

        successCounterText.text = successAttempts.ToString();
        mistakesCounterText.text = (10 - successAttempts).ToString();
    }

    public void ActiveQuestionsPanel()
    {
        resultsPanel.SetActive(false);
        questionsPanel.SetActive(true);

        currentQuestion = 0; //we return to the first question
        successAttempts = 0; //reset the succescounter
        PcChoose(); //the pc choose a the first answer
        PlaceOptions(); //we place on screen the first question
        
    }
}
