public class WoodenHouseBuilder : HouseBuilder
{
    public override void BuildFloors() => house.floors = 2;
    public override void BuildWalls() => house.wallMaterial = "Wood";
    public override void BuildRoof() => house.roofType = "Gable";
    
}