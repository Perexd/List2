using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class exercice1_waves : MonoBehaviour
{
    public int wave = 1; 
    public GameObject sphere; 
    public float enemiesleft = 1; 
    private float uplimit = 4.50f; 
    private float downlimit = 8.50f; 

    private void Start()
    {
        enemiesleft = 1;
    }
    void Update()
    {
        if(enemiesleft == 0) 
        {
            wave += 1; 
            enemiesleft = wave;

            for(int i = 0; i < enemiesleft; i++) 
            {
                Instantiate(sphere, RandomPosition(), gameObject.transform.rotation);
            }
        }
    }
    private Vector3 RandomPosition() 
    {
        return new Vector3(Random.Range(-downlimit, downlimit), Random.Range(-uplimit, uplimit), 0);
    }
}
