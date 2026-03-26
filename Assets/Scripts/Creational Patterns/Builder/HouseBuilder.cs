using UnityEngine;
public abstract class HouseBuilder : MonoBehaviour
{
    protected GameObject houseObject;
    protected House house;

    protected virtual void Awake()
    {
        houseObject = new GameObject("House");
        house = houseObject.AddComponent<House>();
    }

    public abstract void BuildFloors();
    public abstract void BuildWalls();
    public abstract void BuildRoof();

    public House GetHouse() => house;
}