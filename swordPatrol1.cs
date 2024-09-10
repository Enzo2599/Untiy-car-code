using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordPatrol1 : MonoBehaviour
{
    public float speed;  // Speed of the balls
    public float offset; // Offset for the movement
    public GameObject[] swords;  // Array of balls to move
    public int count = 17;      // Number of balls to patrol
    private float[] initialXPositions; // To store initial x positions of the balls


    // Start is called before the first frame update
    void Start()
    {
        initialXPositions = new float[swords.Length];

        // Store initial x positions of each ball
        for (int i = 0; i < swords.Length; i++)
        {
            initialXPositions[i] = swords[i].transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < swords.Length; i++)
        {
            // Move each ball on the X-axis using sine wave for patrol effect
            float newX = initialXPositions[i] + Mathf.Sin(Time.time * speed + i) * offset;
            swords[i].transform.position = new Vector2(newX, swords[i].transform.position.y);
        }
    }
}
