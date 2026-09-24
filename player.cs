using System.Collections.Generic;

public class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Attack;
    public int Level;
    public bool InBattle;
    public List<Inventory> Inventory;
    public Weapon CurrentWeapon;
    public Weapon CurrentArmor;
    public Location CurrentLocation;
    public Dictionary<int, int> EnemiesDefeated;

    public Player(string name, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
        Attack = 5;
        Level = 1;
        InBattle = false;
        Inventory = new List<Inventory>();
        EnemiesDefeated = new Dictionary<int, int>();
    }

    public void RecordEnemyDefeat(int enemyId)
    {
        if (EnemiesDefeated.ContainsKey(enemyId))
        {
            EnemiesDefeated[enemyId]++;
        }
        else
        {
            EnemiesDefeated.Add(enemyId, 1);
        }
    }

    public int GetEnemyDefeats(int enemyId)
    {
        if (EnemiesDefeated.ContainsKey(enemyId))
        {
            return EnemiesDefeated[enemyId];
        }

        return 0;
    }
}