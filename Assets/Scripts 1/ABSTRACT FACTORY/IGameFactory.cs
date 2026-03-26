using UnityEngine;

public interface IGameFactory
{
    IHero CreateHero(Vector3 pos);
    IWeapon CreateWeapon(Vector3 pos);
}