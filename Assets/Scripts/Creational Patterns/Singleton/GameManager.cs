using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton

    public int playerScore;
    public int playerHealth;

    // cách dùng trong bất kỳ scripts nào 
    //GameManager.Instance.AddScore(10);
    //GameManager.Instance.TakeDamage(5);

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Giữ GameManager qua các scene
        }
        else
        {
            Destroy(gameObject); // Không cho tạo instance thứ 2
        }
    }

    public void AddScore(int amount)
    {
        playerScore += amount;
        Debug.Log("Score: " + playerScore);
    }

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        Debug.Log("Health: " + playerHealth);
    }
}