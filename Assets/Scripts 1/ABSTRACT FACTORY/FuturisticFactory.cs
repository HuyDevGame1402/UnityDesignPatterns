using UnityEngine;

public class FuturisticFactory : IGameFactory
{
    public IHero CreateHero(Vector3 pos)
    {
        GameObject obj = new GameObject("SpaceHero");
        obj.transform.position = pos;
        return obj.AddComponent<SpaceHero>();
    }

    public IWeapon CreateWeapon(Vector3 pos)
    {
        GameObject obj = new GameObject("LaserWeapon");
        obj.transform.position = pos;
        return obj.AddComponent<LaserWeapon>();
    }
}