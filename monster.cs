public class Monster
{
    public int ID;
    public string Name;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;

    public Monster(int id, string name, int maximumdamage, int currenthitpoints, int maximumhitpoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumdamage;
        CurrentHitPoints = currenthitpoints;
        MaximumHitPoints = maximumhitpoints;
class Monster
{
    int ID;
    string Name;
    int MaximumDamage;
    int CurrentHitPoints;
    int MaximumHitPoints;
    bool Boss;

    public Monster(int id, string name, int maximumDamage, int currentHitPoints, int maximumHitPoints, bool boss)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
        Boss = boss;
    }
}