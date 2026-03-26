using UnityEngine;

public class MedievalFactory : IGameFactory
{
    public IHero CreateHero(Vector3 pos)
    {
        GameObject obj = new GameObject("KnightHero");
        obj.transform.position = pos;
        return obj.AddComponent<KnightHero>();
    }

    public IWeapon CreateWeapon(Vector3 pos)
    {
        GameObject obj = new GameObject("SwordWeapon");
        obj.transform.position = pos;
        return obj.AddComponent<SwordWeapon>();
    }
}