/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 31, 2025
//
// Brief Description : opens level 1
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLvl1 : MonoBehaviour
{
    /// <summary>
    /// opens level 1
    /// </summary>
    public void OpenLevelOne()
    {
        SceneManager.LoadScene(2);
    }
}
