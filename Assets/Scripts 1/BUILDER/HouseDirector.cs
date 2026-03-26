using UnityEngine;

public class HouseDirector : MonoBehaviour
{
    public HouseBuilder builder;

    public void Construct()
    {
        builder.BuildWalls();
        builder.BuildRoof();
        builder.BuildFloors();
        House house = builder.GetHouse();
        house.Show();
    }

    void Start()
    {
        builder = new WoodenHouseBuilder();
        Construct();
    }
}