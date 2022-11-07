using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exercice1_Waves : MonoBehaviour
{
    public int currentWave = 1; //Which wave of enemies we are playing

    public GameObject spherePrefab; //The prefab of the enemy we will destroy and spawn during the game
    public float enemiesLeft = 1; //Number of enemies alive in scene

    private float upLimit = 4.71f; //Limit of the screen in Y
    private float sideLimit = 8.67f; //Limit of the screen in X

    private void Start()
    {
        enemiesLeft = 1;
    }

    void Update()
    {
        if(enemiesLeft == 0) //When the enemies in scene are all destroyed
        {
            currentWave += 1; //We go to the next wave
            //enemiesLeft = Mathf.Pow(2, currentWave);//And the next number of enemies will be exponentialy increased
            enemiesLeft = currentWave; //Every new Wave the num of enemies will be increased by the same number of enemies than waves.

            for(int i = 0; i < enemiesLeft; i++) //For spawning the next wave of enemies for each enemie we want we instantiate a sphere on screen
            {
                Instantiate(spherePrefab, RandomPosition(), gameObject.transform.rotation);
            }
        }
    }

    private Vector3 RandomPosition() //Obtain a random position for the instantiation of enemies, inside the dimention of the screen
    {
        return new Vector3(Random.Range(-sideLimit, sideLimit), Random.Range(-upLimit, upLimit), 0);
    }
}
