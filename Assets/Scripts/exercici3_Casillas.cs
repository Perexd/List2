using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercici3_Casillas : MonoBehaviour
{
    private int movement = 150; 
    private int boardLimit = 300;
    private bool mover = true; 
    private float speed = 170f; 
    private Vector3 nextPosition; 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) && mover)
        {
            if(transform.position.x != boardLimit) 
            {
                nextPosition = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) && mover) 
        {
            if (transform.position.x != -boardLimit)
            {
                nextPosition = new Vector3(transform.position.x - movement, transform.position.y, transform.position.z);
            }
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && mover)  
        {
            if (transform.position.y != boardLimit)
            {
                nextPosition = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && mover) 
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
            mover = true;
            
        }
    }
    public void Moving()
    {
        mover = false; 

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime); 
    }
}