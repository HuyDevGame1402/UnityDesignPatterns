using UnityEngine;
public abstract class Monster : MonoBehaviour
{
    public string monsterName;
    public int health;
    public abstract Monster Clone();
}