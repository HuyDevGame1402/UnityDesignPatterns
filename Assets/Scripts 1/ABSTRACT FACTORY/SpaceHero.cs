using UnityEngine;

public class SpaceHero : MonoBehaviour, IHero
{
    public void Info() => Debug.Log("Space Marine");
}