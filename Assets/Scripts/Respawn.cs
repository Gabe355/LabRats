/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 17, 2025
//
// Brief Description : Respawns the player
*****************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private GameObject respawnPoint;
    /// <summary>
    /// checks for player collision to respawn them
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            RespawnPlayer();
        }
    }
    /// <summary>
    /// Checks for objects with the "Respawn" tag 
    /// and brings the player there
    /// </summary>
    private void RespawnPlayer()
    {
        GameObject[] ground = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject g in ground)
        {
            playerTransform.position = new Vector3(g.transform.position.x, g.transform.position.y + 3, g.transform.
                position.z);
        }
    }
    private void PlayerHover()
    {

    }
}
