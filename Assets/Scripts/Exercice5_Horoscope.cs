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
        year = int.Parse(yearInputField.text); //we save the number introduced in the variable year
        horoscopeInt = year % 12; //The result of this operation is the horoscope of the person

        horoscopePanel.SetActive(true);
        inputPanel.SetActive(false);

        yourHoroscope.text = $"You were born the year of {horoscopes[horoscopeInt]}";
        animalImage.sprite = animals[horoscopeInt];
    }

    public void returnButton()
    {
        inputPanel.SetActive(true);
        horoscopePanel.SetActive(false);
    }
}
