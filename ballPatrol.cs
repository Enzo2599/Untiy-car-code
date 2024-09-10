using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ballPatrol : MonoBehaviour

{
    public float speed;  // Speed of the balls
    public float offset; // Offset for the movement
    public GameObject[] balls;  // Array of balls to move
    public int count = 17;      // Number of balls to patrol
    private float[] initialXPositions; // To store initial x positions of the balls
    public GameObject character;
    public float moveSpeed;
    private Rigidbody2D rb;       // Reference to the Rigidbody2D component for physics-based movement


    // Start is called before the first frame update
    void Start()
    {
        initialXPositions = new float[balls.Length];

        // Store initial x positions of each ball
        for (int i = 0; i < balls.Length; i++)
        {
            initialXPositions[i] = balls[i].transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < balls.Length; i++)
        {
            // Move each ball on the X-axis using sine wave for patrol effect
            float newX = initialXPositions[i] + Mathf.Sin(Time.time * speed + i) * offset;
            balls[i].transform.position = new Vector2(newX, balls[i].transform.position.y);
        }
    }
}
