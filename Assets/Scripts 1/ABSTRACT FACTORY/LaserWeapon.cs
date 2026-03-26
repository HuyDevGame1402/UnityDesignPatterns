using UnityEngine;

public class LaserWeapon : MonoBehaviour, IWeapon
{
    public void Info() => Debug.Log("Laser Gun");
}