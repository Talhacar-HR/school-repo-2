class Monster
{
    int ID;
    string Name;
    int MaximumDamage;

    int CurrentHitPoints;
    int MaximumHitPoints;

    public Monster(int id, string name, int maximumDamage, int currentHitPoints, int maximumHitPoints)
    {
        ID = id;
        Name = name;
        MaximumDamage = maximumDamage;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
    }
}