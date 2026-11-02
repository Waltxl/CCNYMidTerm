using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public int totalCoins;
    public int collectedCoins;
    void Start()
    {
        totalCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        collectedCoins = 0;
    }
    public void CollectCoin()
    {
        collectedCoins++;
    }
    public bool AllCoinsCollected()
    {
        return collectedCoins >= totalCoins;
    }
}
