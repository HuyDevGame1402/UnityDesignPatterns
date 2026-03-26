using UnityEngine;
public class HouseDirector : MonoBehaviour
{
    private HouseBuilder builder;

    public void SetBuilder(HouseBuilder builder) => this.builder = builder;

    public void ConstructHouse()
    {
        builder.BuildFloors();
        builder.BuildWalls();
        builder.BuildRoof();
        House house = builder.GetHouse();
        house.Show();
    }
    private void Start(){
        builder = new WoodenHouseBuilder();
        ConstructHouse();
    }
}