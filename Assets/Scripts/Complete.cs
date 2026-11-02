using UnityEngine;
using UnityEngine.SceneManagement;

public class Complete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager coins = FindFirstObjectByType<CoinManager>();

            if (coins.AllCoinsCollected())
            {
                SceneManager.LoadScene("Game Complete");
            }
            else
            {
                Debug.Log("Collect all coins before finishing!");
            }
        }
    }
}
