using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab16witchcode : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public Vector3 sue;
    public bool gameStopped; // New variable to track game state
    
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.1f;
        rotateSpeed = 50f;
        gameStopped = false; // Initialize game state to not stopped
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStopped) // Only move if game is not stopped
        {
            if (Input.GetKey("w"))
            {
                transform.Translate(Vector3.up * moveSpeed);
            }
            if (Input.GetKey("s"))
            {
                transform.Translate(Vector3.down * moveSpeed);
            }
        }

        // Check x-axis position
        if (transform.position.x >= 45f)
        {
            StopGame(); // Call the function to stop the game
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        print("GAME OVER");
        StopGame(); // Stop the game on collision
    }

    public void resetGame()
    {
        sue = new Vector3(23.8f, 0.3f, 0f);
        transform.position = sue;
        gameStopped = false; // Reset game state to not stopped
    }
    
    void StopGame()
    {
        gameStopped = true; // Set game state to stopped
        // Perform any additional actions you want when the game stops
    }
}
