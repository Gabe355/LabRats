/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 10, 2025
//
// Brief Description : Restarts the game state
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    /// <summary>
    /// Restarts the current level
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
