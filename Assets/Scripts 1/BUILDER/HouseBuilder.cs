using UnityEngine;

public abstract class HouseBuilder
{
    protected GameObject houseObject;
    protected House house;

    private void Start()
    {
        houseObject = new GameObject("House");
        house = houseObject.AddComponent<House>();
    }

    public abstract void BuildWalls();
    public abstract void BuildRoof();
    public abstract void BuildFloors();
    public House GetHouse() => house;
}