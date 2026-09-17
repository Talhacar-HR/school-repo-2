public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    bool Boss;

    public Monster(int id, string name, int maximumdamage, int currenthitpoints, int maximumhitpoints, bool boss)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumdamage;
        CurrentHitPoints = currenthitpoints;
        MaximumHitPoints = maximumhitpoints;
        Boss = boss;
    }
}