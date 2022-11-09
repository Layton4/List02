using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercici3_Casillas : MonoBehaviour
{
    private int movement = 150; //The distance between each square on the board
    private int boardLimit = 300;

    private bool canMove = true; //boolean to detect if we can move in that moment
    private float speed = 155f; //the speed the player will move from one square to the next
    private Vector3 nextPosition; //the position the player is ordered to move next


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && canMove)
        {
            if(transform.position.x != boardLimit) //if we want to move, we are not at the limit of the board and we can move
            {
                nextPosition = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
            }
        }

        else if(Input.GetKeyDown(KeyCode.LeftArrow) && canMove) //if we want to move, we are not at the limit of the board and we can move
        {
            if (transform.position.x != -boardLimit)
            {
                nextPosition = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
            }
        }

        else if(Input.GetKeyDown(KeyCode.UpArrow) && canMove) //if we want to move, we are not at the limit of the board 
        {
            if (transform.position.y != boardLimit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
            }
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && canMove) //if we want to move, we are not at the limit of the board and we can move
        {
            if (transform.position.y != -boardLimit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y - movement, transform.position.z);
            }
        }

        if (nextPosition != transform.position) //if we ordered the player to move
        {
            //StartCoroutine(MovePlayer());
            Moving();
        }
        if (nextPosition == transform.position)
        {
            canMove = true;
            //StopAllCoroutines();
        }
    }

    public IEnumerator MovePlayer()
    {
        canMove = false;

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
        yield return new WaitForSeconds(0f);
    }

    public void Moving()
    {
        canMove = false; //we avoid any other movement until we arrive to the next square

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime); //our movement
    }
}
