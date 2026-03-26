using UnityEngine;
public class LaserWeapon : MonoBehaviour, IWeapon
{
    public void Info()
    {
        Debug.Log("This is a Laser Weapon");
    }
}