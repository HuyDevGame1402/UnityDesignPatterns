using UnityEngine;

public class Weapon : MonoBehaviour
{
    private IShootStrategy shootStrategy;

    public void SetStrategy(IShootStrategy strategy)
    {
        shootStrategy = strategy;
    }

    public void Shoot()
    {
        shootStrategy?.Shoot(transform);
    }

    // cách sử dụng
    //weapon.SetStrategy(new Shotgun());
    //weapon.Shoot();
}