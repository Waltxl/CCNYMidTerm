using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetString("Checkpoint", "Level 1");
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager coins = FindFirstObjectByType<CoinManager>();

            if (coins.AllCoinsCollected())
            {
                PlayerPrefs.SetString("Checkpoint", "Level 2");
                SceneManager.LoadScene("Level 2");
            }
            else
            {
                Debug.Log("Collect all coins before continuing!");
            }
        }
    }
}
