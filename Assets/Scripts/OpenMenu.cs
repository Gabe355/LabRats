/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 31, 2025
//
// Brief Description : sends player to the main menu
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenu : MonoBehaviour
{
    /// <summary>
    /// opens the main menu
    /// </summary>
    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
