using UnityEngine;
public interface IGameFactory
{
    IHero CreateHero(Vector3 position);
    IWeapon CreateWeapon(Vector3 position);
}