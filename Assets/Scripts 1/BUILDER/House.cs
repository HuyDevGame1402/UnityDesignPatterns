using UnityEngine;

public class House : MonoBehaviour
{
    public int floors;
    public string wallMaterial;
    public string roofType;

    public void Show() => Debug.Log($"House: {floors} floors, Wall: {wallMaterial}, Roof: {roofType}");
}