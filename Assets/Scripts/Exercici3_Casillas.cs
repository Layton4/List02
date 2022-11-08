using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercici3_Casillas : MonoBehaviour
{
    private int movement = 150;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(transform.position.x != 300)
            {
                gameObject.transform.position = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
            }
        }

        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x != -300)
            {
                gameObject.transform.position = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
            }
        }

        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.y != 300)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
            }
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.y != -300)
            {
                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - movement, transform.position.z);
            }
        }
    }
}
