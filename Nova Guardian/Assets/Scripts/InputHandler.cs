using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject projectilePrefab; // Drag your projectile prefab here in the Inspector
    public Transform launchPoint; // The point from where the projectile will be launched

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Left mouse button
        {
            LaunchProjectile();
        }
    }

    void LaunchProjectile()
    {
        // Instantiate the projectile at the launch point
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);

        // Calculate the direction to launch the projectile
        Vector3 launchDirection = CalculateLaunchDirection();
        projectile.GetComponent<Projectile>().Launch(launchDirection);
    }

    Vector3 CalculateLaunchDirection()
    {
        // Assuming you want to launch towards the camera's forward direction
        return Camera.main.transform.forward;
    }
}
