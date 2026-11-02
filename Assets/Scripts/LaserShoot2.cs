using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserShoot2 : MonoBehaviour
{
    public float speed = 8f;
    void Update()
    {
        // Move the laser to the left
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Destroy the laser after 5 seconds
        Destroy(gameObject, 5f);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
