using UnityEngine;
public class MonsterSpawner : MonoBehaviour
{
    public Monster monsterPrefab;

    void Start()
    {
        SpawnMonster();
    }

    void SpawnMonster()
    {
        Monster newMonster = monsterPrefab.Clone();
        newMonster.transform.position = new Vector3(0, 0, 0);
        newMonster.monsterName = "Orc";
        newMonster.health = 100;
    }
}