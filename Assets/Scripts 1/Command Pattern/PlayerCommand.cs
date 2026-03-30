using UnityEngine;

public class PlayerCommand : MonoBehaviour
{
    public int damage = 10;
    public void Attack()
    {
        Debug.Log("Player attacks with damage: " + damage);
    }
}
