using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Check for pause input (e.g., pressing the 'Escape' key)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0; // Stops the time
        isPaused = true;
        // Show your pause menu UI here
    }

    void ResumeGame()
    {
        Time.timeScale = 1; // Resumes the time
        isPaused = false;
        // Hide your pause menu UI here
    }
}
