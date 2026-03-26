using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    void Start()
    {
        EnemyFactory factory = new GoblinFactory();
        Enemy goblin = factory.CreateEnemy(new Vector3(0, 0, 0));
        goblin.Attack();

        factory = new OrcFactory();
        Enemy orc = factory.CreateEnemy(new Vector3(2, 0, 0));
        orc.Attack();
    }
}