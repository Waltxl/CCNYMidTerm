using UnityEngine;

public class PillarRotate : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }
}
