/*****************************************************************************
// File Name : andrewsGabrielAlpha
// Author : Gabriel Andrews
// Creation Date : March 7, 2025
//
// Brief Description : handles player interactions
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float jumpValue;
    [SerializeField] private TMP_Text speedText;
    [SerializeField] private float maxSpeed;
    private Rigidbody rb;
    private Vector2 movementValue;
    private Vector3 playerMovement;
    private bool isTrapped;
    private bool canJump;
    public bool increasingSpeed;
    private Quaternion targetRotation;

    /// <summary>
    /// sets up player movement and rigid body
    /// </summary>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetRotation = transform.rotation;
        playerInput.currentActionMap.Enable();
        canJump = true;
    }
    /// <summary>
    /// lets the player jump if theyr not trapped.
    /// </summary>
    void OnJump()
    {
        int freeChance = Random.Range(1, 4);//sets a random value everytime the player jumps
        if (freeChance == 1)//if the random value is equal to 1 the player is freed
        {
            isTrapped = false;
        }
        if (!isTrapped && canJump)
        {
            rb.velocity = new Vector3(0, jumpValue, 0);
            canJump = false;    
        }
    }
    /// <summary>
    /// sets up the players movement vector
    /// </summary>
    /// <param name="iValue"></param>
    void OnMove(InputValue iValue)
    {
        movementValue = iValue.Get<Vector2>();
        playerMovement.x = movementValue.y;
        playerMovement.z = movementValue.x;
        StartCoroutine(increaseSpeed());     
    }
    /// <summary>
    /// Restarts Scene
    /// </summary>
    void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    /// <summary>
    /// Quits game
    /// </summary>
    void OnQuit()
    {
        Application.Quit();
    }
    /// <summary>
    /// moves the player if theyre not trapped
    /// </summary>
    private void FixedUpdate()
    {
        if (!isTrapped)
        {
            rb.angularVelocity = Vector3.up * playerMovement.z * turnSpeed * Mathf.Deg2Rad;
            Vector3 currentVelocity = rb.velocity;
            Vector3 forwardMovement = transform.forward * playerMovement.x * speed;
            forwardMovement.y = currentVelocity.y; 
            rb.velocity = forwardMovement;
        }
        if(playerMovement.x == 0 && !isTrapped)
        {
            BaseSpeed();
        }
    }
    /// <summary>
    /// sets the players speed back to base when freed
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("GlueTrap"))
        {
            BaseSpeed();
        }
        if (other.gameObject.CompareTag("GrabTrap"))
        {
            BaseSpeed();    
        }
    }
    /// <summary>
    /// slows/stops the player when theyre in a trap
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("GlueTrap"))
        {
            speed = 3;
            turnSpeed = 50;
        }
        if (other.gameObject.CompareTag("GrabTrap"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            isTrapped = true;
        }
        if (other.gameObject.CompareTag("GunTrap"))
        {
            StartCoroutine(StunPlayer());
        }
    }
    /// <summary>
    /// checks for when the player lands on a platform
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            canJump = true;           
        }
    }
    /// <summary>
    /// sets the players speed to base
    /// </summary>
    private void BaseSpeed()
    {
        speed = 25;
        turnSpeed = 200;
        speedText.text = speed.ToString();
        increasingSpeed = false;    
        StopCoroutine(increaseSpeed());
    }
    /// <summary>
    /// stuns player for a set amount of time
    /// </summary>
    /// <returns></returns>
    IEnumerator StunPlayer()
    {
        speed = 0;
        turnSpeed = 0;
        speedText.text = speed.ToString();
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        isTrapped = true;
        yield return new WaitForSeconds(3);
        BaseSpeed();
        isTrapped = false;

    }
    /// <summary>
    /// speeds up player
    /// </summary>
    /// <returns></returns>
    IEnumerator increaseSpeed()
    {
        increasingSpeed = true;
        while (increasingSpeed)
        {    
            if (speed < maxSpeed && !isTrapped)
            {
                speed += 1;
                turnSpeed += 2;
            }
            speedText.text = speed.ToString();
            yield return new WaitForSeconds(1f);
        }  
    }
 

}
