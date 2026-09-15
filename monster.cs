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