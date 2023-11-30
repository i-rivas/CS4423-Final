using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    private GameObject player;

    private bool hasLineOfSight = false;

    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float jumpInterval = 2f;
    private float jumpTimer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if(hasLineOfSight)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

            jumpTimer += Time.deltaTime;
            if (jumpTimer >= jumpInterval)
            {
                JumpTowardsPlayer();
                jumpTimer = 0;
            }
        }
    }

    void JumpTowardsPlayer()
    {
    // Assuming you have a Rigidbody2D attached to your AI
    Rigidbody2D rb = GetComponent<Rigidbody2D>();
    if (rb != null)
    {
        Vector2 jumpDirection = (player.transform.position - transform.position).normalized;
        jumpDirection.y = 1; // Ensure there's vertical component in the jump
        rb.AddForce(jumpDirection * jumpForce, ForceMode2D.Impulse);
    }
    }

    private void FixedUpdate() 
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position);
        if(ray.collider != null)
        {
            hasLineOfSight = ray.collider.CompareTag("Player");
            if(hasLineOfSight)
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.green);
            }
            else
            {
                Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
            }
        }        
    }
}
