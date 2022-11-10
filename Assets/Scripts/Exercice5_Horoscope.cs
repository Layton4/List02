using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercice5_Horoscope : MonoBehaviour
{
    public string[] horoscopes;
    public GameObject inputPanel;
    public TMP_InputField yearInputField;
 
    public GameObject horoscopePanel;
    public TextMeshProUGUI yourHoroscope;
    public Image animalImage;
    public Sprite[] animals;
    

    public int year;
    public int horoscopeInt;

    void Start()
    {
        returnButton();
    }

    public void ConfirmButton() //When we are done introducing our birth year we hit the button confirm
    {
        if(yearInputField.text != "")
        {
            year = int.Parse(yearInputField.text); //we save the number introduced in the variable year
            horoscopeInt = year % 12; //Every year has an animal, there are 12 horoscope animals, changing every year and repeating the order every 12 years, if we do this operation with your birth year, we can know which is your animal

            horoscopePanel.SetActive(true);
            inputPanel.SetActive(false);

            yourHoroscope.text = $"You were born the year of {horoscopes[horoscopeInt]}";
            animalImage.sprite = animals[horoscopeInt];
        }
        
    }

    public void returnButton() //We turn off the panel where we saw the horoscope animal and turn on the panel to introduce our birth year
    {
        inputPanel.SetActive(true);
        horoscopePanel.SetActive(false);
    }
}
