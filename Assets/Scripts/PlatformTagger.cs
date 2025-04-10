/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 25, 2025
//
// Brief Description : tags, and untags platforms
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTagger : MonoBehaviour
{
    /// <summary>
    /// checks for when the player lands on a platform
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Untagger();
            collision.gameObject.tag = "Respawn";
        }
    }
    /// <summary>
    /// removes the respawn tag when the player touches another platform
    /// </summary>
    private void Untagger()
    {
        GameObject[] tagged = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject t in tagged)
        {
            t.tag = "Untagged";
        }
    }
}
