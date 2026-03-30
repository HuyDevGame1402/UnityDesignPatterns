using UnityEngine;

public class Shotgun : IShootStrategy
{
    public void Shoot(Transform firePoint)
    {
        int pelletCount = 5;
        float spread = 10f;

        for (int i = 0; i < pelletCount; i++)
        {
            float angle = Random.Range(-spread, spread);
            Quaternion rot = firePoint.rotation * Quaternion.Euler(0, 0, angle);

            //GameObject.Instantiate(Resources.Load("Bullet"), firePoint.position, rot);
            Debug.Log("Shoot Pellet " + (i + 1) + " with angle: " + angle);
        }
    }
}