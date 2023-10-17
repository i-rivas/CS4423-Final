using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform playerTransform;  // Reference to the player's transform
    public Vector3 offset;             // Offset between the camera and player

    private void LateUpdate()
    {
        // Set the camera's position based on the player's position and the offset
        transform.position = playerTransform.position + offset;
    }
}
