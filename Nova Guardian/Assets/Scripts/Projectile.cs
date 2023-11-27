using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f; // Time after which the projectile is automatically destroyed

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    public void Launch(Vector3 direction)
    {
        GetComponent<Rigidbody>().velocity = direction * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the projectile upon collision
        Destroy(gameObject);
    }
}
