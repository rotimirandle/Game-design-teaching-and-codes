public class Hero : Unit
{
    public Hero()
    {
        stats = new HeroStats();
    }

    public void IsHit(int objectDamage)
    {
        stats.TakeDamage(objectDamage);
    }
    /// <summary>
    /// ////////////////////////////////////
    /// </summary>
    public void GetMad()
    {
        stats = new SSJStats();
    }

    public override string ToString()
    {
        return "HP: " + stats.Hp + "\n" + "ATK: " + stats.Atk + "\n" + "DEF: " + stats.Def;
    }
}
