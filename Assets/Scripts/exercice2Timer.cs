using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class exercice2Timer : MonoBehaviour
{
    public float time = 10; 
    public float maxTime; 
    public TextMeshProUGUI timerNumber; 
    public Image timeBar;
    private bool countTime = false; 
    private bool canClick = true;
    public GameObject ringText; 
    
    void Start()
    {
        timerNumber.text = time.ToString(); 
    }
    void Update()
    {
    if (countTime && time > 0) 
    {
     time -= Time.deltaTime;
     timerNumber.text = Mathf.Round(time).ToString();
     timeBar.fillAmount = time / maxTime;
    }
    if (time <= 0 && countTime) 
    {
     canClick = true; 
     countTime = false; 
     ringText.SetActive(true); 
     time = maxTime; 
     timerNumber.text = time.ToString();
    }
}
    public void MoreTime() 
    {
    if(countTime == false)
    {
     time += 1;
     timerNumber.text = time.ToString();
    }   
}
    public void LessTime() 
    {
    if(countTime == false)
    {
     time -= 1;
     timerNumber.text = time.ToString();
    }
}
    public void StartButton() 
    {
    if(canClick == true)
    {
     ringText.SetActive(false);
     countTime = true;
     maxTime = time;
     canClick = false;
     }  
    }
}
