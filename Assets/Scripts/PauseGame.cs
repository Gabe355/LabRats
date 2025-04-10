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
    /// <summary>
    /// does nothing yet
    /// </summary>
    void Start()
    {
        playerInput.currentActionMap.Enable();
    }
    private void OnPause()
    {
        //Pause game
    }
}
