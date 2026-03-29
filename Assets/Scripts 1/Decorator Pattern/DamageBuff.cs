public class DamageBuff : DamageDecorator
{
    private int bonus;

    public DamageBuff(IDamage damage, int reduction) : base(damage)
    {
        this.bonus = reduction;
    }
    public override int GetDamage()
    {
        return base.GetDamage() + bonus;
    }
}
