public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public bool Boss;

    public Monster(int id, string name, int maximumdamage, int currenthitpoints, int maximumhitpoints, bool boss = false)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumdamage;
        CurrentHitPoints = currenthitpoints;
        MaximumHitPoints = maximumhitpoints;
        Boss = boss;

        if (boss)
        {
            MaximumDamage *= 2;
            MaximumHitPoints *= 2;
            CurrentHitPoints = MaximumHitPoints;
        }
    }
}