using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCounter : MonoBehaviour
{
    private bool hitByTrap;
    private bool goodTime;
  void Start()
  {
        hitByTrap = false;
        goodTime = true;   
  }
    /// <summary>
    /// detects if the player is hit by a trap
    /// </summary>
  public void HitByTrap()
  {
    hitByTrap = true;  
  }
    /// <summary>
    /// checks if the player beats the level in more than half the time
    /// </summary>
    public void BadTime()
    {
        goodTime = false;
    }
}
