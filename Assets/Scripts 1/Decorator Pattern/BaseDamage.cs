public class BaseDamage : IDamage
{
    private int baseDamage;

    public BaseDamage(int damage)
    {
        baseDamage = damage;
    }
    public int GetDamage()
    {
        return baseDamage;
    }
}
