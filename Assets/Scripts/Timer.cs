/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 7, 2025
//
// Brief Description : handles timer
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private int timer;
    [SerializeField] private int startTime;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private GameObject loseScreen;
    private bool raceEnd;
    private PlayerController playerController;
    /// <summary>
    /// starts the timer, and creates the UI
    /// </summary>
    void Start()
    {
        raceEnd = false;   
        StartCoroutine(CountDown());
        timerText.text = timer.ToString();  
        loseScreen.SetActive(false);
        playerController = GameObject.FindObjectOfType<PlayerController>();
        timer = startTime;  
    }
    /// <summary>
    /// counts the timer down
    /// </summary>
    /// <returns></returns>
    IEnumerator CountDown()
    {    
        while (!raceEnd)
        {
            yield return new WaitForSeconds(1);
            timer -= 1;
            timerText.text = timer.ToString();
            if (timer <= 0)
            {
                raceEnd = true; 
                loseScreen.SetActive(true); 
                playerController.gameObject.SetActive(false);
            }
            if(timer <= startTime / 2)
            {

            }
        }
    }
}
