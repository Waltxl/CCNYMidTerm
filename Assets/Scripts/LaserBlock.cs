using UnityEngine;

public class LaserBlock : MonoBehaviour
{
    public GameObject laserPrefab;
    public float shootInterval = 3f;
    void Start()
    {
        InvokeRepeating("ShootLaser", 0f, shootInterval);
    }

    void ShootLaser()
    {
        Instantiate(laserPrefab, transform.position, transform.rotation);
    }
}
