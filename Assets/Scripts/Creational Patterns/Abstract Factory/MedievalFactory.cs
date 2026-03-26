using UnityEngine;
public class MedievalFactory : IGameFactory
{
    public IHero CreateHero(Vector3 position)
    {
        GameObject heroObject = new GameObject("KnightHero");
        heroObject.transform.position = position;
        return heroObject.AddComponent<KinghtHero>();
    }

    public IWeapon CreateWeapon(Vector3 position)
    {
        GameObject weaponObject = new GameObject("SwordWeapon");
        weaponObject.transform.position = position;
        return weaponObject.AddComponent<SwordWeapon>();
    }
}