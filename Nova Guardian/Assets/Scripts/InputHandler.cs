using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint;
    public GameObject player; // Reference to the PlayerScript

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // "Fire1" is typically the left mouse button or Ctrl
        {
            LaunchProjectile();
        }
    }

    void LaunchProjectile()
    {
        // Check the 'flipX' property of the SpriteRenderer to determine the direction
        bool isFacingRight = !player.GetComponent<SpriteRenderer>().flipX;
    
        // Determine the launch direction based on the facing direction
        Vector2 launchDirection = isFacingRight ? Vector2.right : Vector2.left;
    
        // Instantiate the projectile at the launch point and launch it
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
        projectile.GetComponent<Projectile>().Launch(launchDirection);
    }
}
