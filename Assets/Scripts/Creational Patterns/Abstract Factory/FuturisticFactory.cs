using UnityEngine;
public class FuturisticFactory : IGameFactory
{
    public IHero CreateHero(Vector3 position)
    {
        GameObject heroObject = new GameObject("SpaceHero");
        heroObject.transform.position = position;
        return heroObject.AddComponent<SpaceHero>();
    }

    public IWeapon CreateWeapon(Vector3 position)
    {
        GameObject weaponObject = new GameObject("LaserWeapon");
        weaponObject.transform.position = position;
        return weaponObject.AddComponent<LaserWeapon>();
    }
}