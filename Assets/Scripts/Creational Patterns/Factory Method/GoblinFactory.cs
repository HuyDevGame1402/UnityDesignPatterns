using UnityEngine;
public class GoblinFactory : EnemyFactory
{
    public override Enemy CreateEnemy(Vector3 position)
    {
        GameObject objectGoblin = new GameObject("Goblin");
        objectGoblin.transform.position = position;
        return objectGoblin.AddComponent<Goblin>();
    }
}