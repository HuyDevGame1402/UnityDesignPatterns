using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int> OnHealthChanged;

    private int health = 100;

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        OnHealthChanged?.Invoke(health);
    }
}