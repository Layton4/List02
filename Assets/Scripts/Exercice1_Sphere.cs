using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercice1_Sphere : MonoBehaviour
{
    public GameObject spherePrefab;

    private Exercice1_Waves WavesScripts;

    void Start()
    {
        WavesScripts = FindObjectOfType<Exercice1_Waves>();
    }

    private void OnMouseDown() //When we click on a sphere/enemy, we destroy it and we update the enemy counter to know how many sphere still alive on screen
    {
        WavesScripts.enemiesLeft -= 1;
        Destroy(gameObject);
    }

    
}
