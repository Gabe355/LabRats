using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoints : MonoBehaviour
{
    [SerializeField] private GameObject[] movePoints;
    [SerializeField] private float speed;
    private int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, movePoints[currentIndex].transform.position) < 0.1)
        {
            //adds to the idex of the array, and resets it if it maxes out
            currentIndex++;

            if (currentIndex == movePoints.Length)
            {
                currentIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, movePoints[currentIndex].transform.position,
            speed * Time.deltaTime);
    }
}
