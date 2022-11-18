using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercici3_Casillas : MonoBehaviour
{
    private int movement = 150; 
    private int boardLimit = 300;
    private bool canMove = true; 
    private float speed = 170f; 
    private Vector3 nextPosition; 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && canMove)
        {
            if(transform.position.x != boardLimit) 
            {
                nextPosition = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && canMove) 
        {
            if (transform.position.x != -boardLimit)
            {
                nextPosition = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && canMove)  
        {
            if (transform.position.y != boardLimit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && canMove) 
        {
            if (transform.position.y != -boardLimit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y - movement, transform.position.z);
            }
        }
        if (nextPosition != transform.position) 
        {
            
            Moving();
        }
        if (nextPosition == transform.position) 
        {
            canMove = true;
            
        }
    }
    public void Moving()
    {
        canMove = false; 

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime); 
    }
}