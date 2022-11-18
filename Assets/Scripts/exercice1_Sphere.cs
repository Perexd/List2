using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercice1_Sphere : MonoBehaviour
{
    public GameObject spherePrefab;
    private exercice1_waves oleada;

    void Start()
    {
        oleada = FindObjectOfType<exercice1_waves>();
    }

    private void OnMouseDown()
    {
        oleada.enemiesleft -= 1;
        Destroy(gameObject);
    }

    
}
