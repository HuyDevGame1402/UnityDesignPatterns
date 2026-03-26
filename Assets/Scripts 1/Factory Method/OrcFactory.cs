using UnityEngine;

public class OrcFactory : EnemyFactory
{
    public override Enemy CreateEnemy(Vector3 position)
    {
        GameObject obj = new GameObject("Orc");
        obj.transform.position = position;
        return obj.AddComponent<Orc>();
    }
}