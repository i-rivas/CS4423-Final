using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalCollectible : MonoBehaviour
{
    public float respawnHeight = 6.5f; // This value depends on your camera size
    public float minX = -3.0f; // Minimum X position for respawn
    public float maxX = 3.0f; // Maximum X position for respawn
    public float fallSpeed = 2.0f; // Speed at which the object falls

    public int pointValue = 1; // Value of each crystal
    private static int totalPoints = 0; // Static variable to keep track of total points
    public Text pointsCounter; // Reference to the UI Text component

    private void Start()
    {
        // Find the PointsCounter text in the scene and get its Text component
        pointsCounter = GameObject.Find("PointsCounter").GetComponent<Text>();
        UpdatePointsCounter();
        totalPoints = 0;
    }

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            totalPoints += pointValue; // Increase the total points
            UpdatePointsCounter(); // Update the UI
        }

        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().sortingOrder = 0;
        StartCoroutine(DestroyAfterSound());
        
    }



    
    IEnumerator DestroyAfterSound()
    {
        float clipLength = GetComponent<AudioSource>().clip.length;
        yield return new WaitForSeconds(clipLength);
        Destroy(gameObject);
    }

    private void UpdatePointsCounter()
    {
        pointsCounter.text = "POINTS: " + totalPoints;
    }

}
