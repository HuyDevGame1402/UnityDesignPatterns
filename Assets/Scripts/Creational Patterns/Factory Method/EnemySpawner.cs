using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private void Start(){
        EnemyFactory factory = new GoblinFactory();
        Enemy goblin = factory.CreateEnemy(new Vector3(0, 0, 0));
        goblin.Attack();

        factory = new OrcFactory();
        Enemy orc = factory.CreateEnemy(new Vector3(1, 0, 0));
        orc.Attack();
    }
}