using UnityEngine;
public class House : MonoBehaviour
{
    public int floors;
    public string wallMaterial;
    public string roofType;

    public void Show() => Debug.Log($"House with {floors} floors, made of {wallMaterial} walls and a {roofType} roof.");
}