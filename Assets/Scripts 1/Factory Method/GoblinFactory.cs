using UnityEngine;

public class GoblinFactory : EnemyFactory
{
    public override Enemy CreateEnemy(Vector3 position)
    {
        GameObject obj = new GameObject("Goblin");
        obj.transform.position = position;
        return obj.AddComponent<Goblin>();
    }
}