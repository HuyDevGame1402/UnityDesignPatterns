using UnityEngine;

public abstract class DamageDecorator : IDamage
{
    protected IDamage damage;
    
    public DamageDecorator(IDamage damage)
    {
        this.damage = damage;
    }

    public virtual int GetDamage()
    {
        return damage.GetDamage();
    }
}
