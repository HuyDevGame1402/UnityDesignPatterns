using UnityEngine;

public class GameStarter : MonoBehaviour
{
    void Start()
    {
        IGameFactory factory = new MedievalFactory();
        IHero hero = factory.CreateHero(Vector3.zero);
        IWeapon weapon = factory.CreateWeapon(new Vector3(1, 0, 0));
        hero.Info();
        weapon.Info();

        factory = new FuturisticFactory();
        hero = factory.CreateHero(new Vector3(2, 0, 0));
        weapon = factory.CreateWeapon(new Vector3(3, 0, 0));
        hero.Info();
        weapon.Info();
    }
}