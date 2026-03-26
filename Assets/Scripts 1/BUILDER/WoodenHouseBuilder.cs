using UnityEngine;

public class WoodenHouseBuilder : HouseBuilder
{
    public override void BuildWalls() => house.wallMaterial = "Wood";
    public override void BuildRoof() => house.roofType = "Wooden Roof";
    public override void BuildFloors() => house.floors = 2;
}