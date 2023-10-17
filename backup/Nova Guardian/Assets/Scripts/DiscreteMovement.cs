using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    private float moveSpeed = 5f; // You can adjust this value based on how fast you want the character to move

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    public void Movement(Vector3 vel)
    {
        targetPosition = transform.position + vel;
    }
}
