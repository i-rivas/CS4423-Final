using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    public void Launch(Vector2 direction) // Use Vector2 for 2D
    {
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        if (rb2D != null)
        {
            rb2D.velocity = direction * speed; // Set the velocity once, correctly
            Debug.Log($"Launching projectile in direction {direction} with speed {speed}");
        }
        else
        {
            Debug.LogError("No Rigidbody2D attached to " + gameObject.name);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Destructible")
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
