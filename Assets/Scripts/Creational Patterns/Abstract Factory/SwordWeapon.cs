using UnityEngine;

public class SwordWeapon : MonoBehaviour, IWeapon
{
    public void Info()
    {
        Debug.Log("This is a Sword Weapon");
    }
}