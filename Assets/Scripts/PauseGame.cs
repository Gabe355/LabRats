/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 27, 2025
//
// Brief Description : pauses the game
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private GameObject pauseMenu;
    private bool isPaused;
    
    /// <summary>
    /// does nothing yet
    /// </summary>
    void Start()
    {
        playerInput.currentActionMap.Enable();
        isPaused = false;
        pauseMenu.SetActive(false); 
    }
    private void OnPause()
    {   
        if (!isPaused)
        {
            isPaused = !isPaused;
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);  
        }
        else
        {
            isPaused = !isPaused;
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);          
        }
    }
}
