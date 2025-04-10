/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 31, 2025
//
// Brief Description : opens how to play screen
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHowToPlay : MonoBehaviour
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject H2PScreen;
    /// <summary>
    /// opens how to play screen
    /// </summary>
    public void OpenHowPlayScreen()
    {
        titleScreen.SetActive(false);
        H2PScreen.SetActive(true);
    }
}
