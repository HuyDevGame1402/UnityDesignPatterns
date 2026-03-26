using UnityEngine;

public class SpaceHero : MonoBehaviour, IHero
{
    public void Info()
    {
        Debug.Log("This is a Space Hero");
    }
}