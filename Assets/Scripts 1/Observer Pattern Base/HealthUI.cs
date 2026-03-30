using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public PlayerHealth player;

    private void Start()
    {
        player.OnHealthChanged += UpdateUI;
    }

    private void OnDestroy()
    {
        player.OnHealthChanged -= UpdateUI;
    }

    private void UpdateUI(int hp)
    {
        Debug.Log("HP: " + hp);
    }
}