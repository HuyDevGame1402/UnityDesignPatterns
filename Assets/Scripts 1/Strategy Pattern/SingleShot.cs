using UnityEngine;

public class SingleShot : IShootStrategy
{
    public void Shoot(Transform firePoint)
    {
        //GameObject.Instantiate(Resources.Load("Bullet"), firePoint.position, firePoint.rotation);
        Debug.Log("Shoot");
    }
}