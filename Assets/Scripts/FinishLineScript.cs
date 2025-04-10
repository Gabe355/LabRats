/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 10, 2025
//
// Brief Description : handles finish line interactions
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishLineScript : MonoBehaviour
{
    [SerializeField] private GameObject winBG;
    private PlayerController playerController;  
    /// <summary>
    /// sets up player controller
    /// </summary>
    void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>(); 
    }
    /// <summary>
    /// Sets the Win screen active
    /// </summary>
    private void ShowPanel()
    {
        winBG.SetActive(true);
        playerController.gameObject.SetActive(false);
    }
    /// <summary>
    /// Detects if the player crosses the finish line
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishLine"))
        {
            ShowPanel();    
        }
    }
}
