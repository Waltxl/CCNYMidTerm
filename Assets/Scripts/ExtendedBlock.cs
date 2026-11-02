using UnityEngine;

public class ExtendedBlock : MonoBehaviour
{
    public float speed = 1f;
    public float waitTime = 1f;
    public float originalSize = 1f;
    public float maxSize = 2f;
    private Vector3 startPosition;
    private Vector3 originalScale;
    private bool extending = true;
    private float timer = 0f;
    void Start()
    {
        startPosition = transform.position;
        originalScale = transform.localScale;
    }
    void Update()
    {
        if (extending)
        {
            // Make the block longer downward
            transform.localScale = new Vector3(
                originalScale.x,
                originalScale.y + timer * speed,
                originalScale.z
            );

            transform.position = new Vector3(
                startPosition.x,
                startPosition.y - (transform.localScale.y - originalScale.y) / 2f,
                startPosition.z
            );

            timer += Time.deltaTime;

            if (transform.localScale.y >= maxSize)
            {
                extending = false;
                timer = 0f;
            }
        }
        else
        {
            // Wait before shrinking
            timer += Time.deltaTime;

            if (timer >= waitTime)
            {
                transform.localScale = originalScale;
                transform.position = startPosition;

                extending = true;
                timer = 0f;
            }
        }
    }
}
