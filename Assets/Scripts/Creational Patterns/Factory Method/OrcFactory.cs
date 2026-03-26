using UnityEngine;

public class OrcFactory : EnemyFactory
{
    public override Enemy CreateEnemy(Vector3 position)
    {
        GameObject objectOrc = new GameObject("Orc");
        objectOrc.transform.position = position;
        return objectOrc.AddComponent<Orc>();
    }
}