/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 31, 2025
//
// Brief Description : opens test level
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLvl0 : MonoBehaviour
{
    /// <summary>
    /// opens test level
    /// </summary>
    public void OpenLevelZero()
    {
        SceneManager.LoadScene(1);
    }
}
