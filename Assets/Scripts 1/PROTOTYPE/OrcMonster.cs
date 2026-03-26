using UnityEngine;

public class OrcMonster : Monster
{
    public override Monster Clone()
    {
        GameObject cloneObj = Instantiate(this.gameObject);
        return cloneObj.GetComponent<OrcMonster>();
    }
}