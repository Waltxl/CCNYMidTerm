using UnityEngine;

public class ResetCheckpoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefs.SetString("Checkpoint", "Level 1");
    }
}
