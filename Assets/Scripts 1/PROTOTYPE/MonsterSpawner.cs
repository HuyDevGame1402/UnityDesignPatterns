using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public OrcMonster originalOrc;

    void Start()
    {
        Monster clone1 = originalOrc.Clone();
        clone1.transform.position = new Vector3(1, 0, 0);
        clone1.monsterName = "Orc Clone 1";

        Monster clone2 = originalOrc.Clone();
        clone2.transform.position = new Vector3(2, 0, 0);
        clone2.monsterName = "Orc Clone 2";

        Debug.Log(clone1.monsterName);
        Debug.Log(clone2.monsterName);
    }
}