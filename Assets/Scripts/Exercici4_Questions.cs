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
    public TextMeshProUGUI successCounterText;
    public TextMeshProUGUI mistakesCounterText;

    //Panels
    public GameObject resultsPanel;
    public GameObject questionsPanel;

    //Counters
    private int currentQuestion;
    private int successAttempts;

    void Start()
    {
        ActiveQuestionsPanel();
    }
    public void PcChoose()
    {
        pcChoosing = Random.Range(0, 2); //The Pc choose option 1 or 2
    }

    public void PlaceOptions() //Changing options
    {
     textOption1.text = Options1[currentQuestion];
     textOption2.text = Option2[currentQuestion];
    }

    public void Choosing(int opt) //When we click one option, we see if it's the same option than the pc
    {
        if(opt == pcChoosing)
        {
            successAttempts++;
        }

        if(currentQuestion < 9)
        {
            currentQuestion++;
            PcChoose();
            PlaceOptions();
        }

        if(currentQuestion == 9)
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
        currentQuestion = 0;
        successAttempts = 0;
        PcChoose();
        PlaceOptions();
        
    }
}
