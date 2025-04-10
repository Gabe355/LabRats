/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 31, 2025
//
// Brief Description : opens level 2
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLvl2 : MonoBehaviour
{
    /// <summary>
    /// opens level 2
    /// </summary>
    public void OpenLevelTwo()
    {
        SceneManager.LoadScene(3);
    }
}
