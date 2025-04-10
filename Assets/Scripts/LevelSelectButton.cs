/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 21, 2025
//
// Brief Description : opens level select screen
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectButton : MonoBehaviour
{
    [SerializeField] private GameObject titleScreen;
    [SerializeField] private GameObject lvlSelectScreen;
    /// <summary>
    /// Opens lvl select screen
    /// </summary>
    public void OpenLevelSelectScreen()
    {
        titleScreen.SetActive(false);
        lvlSelectScreen.SetActive(true);
    }
}
