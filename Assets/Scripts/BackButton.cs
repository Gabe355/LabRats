/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 21, 2025
//
// Brief Description : Back button
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject lvlSelectScreen;
    [SerializeField] private GameObject howToPlayScreen;
    /// <summary>
    /// Goes back to the title screen
    /// </summary>
    public void Back()
    {
        titleScreen.SetActive(true);
        lvlSelectScreen.SetActive(false);
        howToPlayScreen.SetActive(false);
    }
    
}
