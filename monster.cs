using System;

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

    public static void SearchForMonster(Player player)
    {
        if (player.CurrentLocation.MonsterLivingHere == null)
        {
            Console.WriteLine("There are no monsters to search for here.");
            return;
        }

        Monster monster = player.CurrentLocation.MonsterLivingHere;
        Quest quest = Quest.QuestForMonster(monster.ID);

        if (quest != null && !quest.IsActive && !quest.IsCompleted)
        {
            Console.WriteLine("Talk to the NPC first to start this quest.");
            return;
        }

        Monster battleMonster = new Monster(
            monster.ID,
            monster.Name,
            monster.MaximumDamage,
            monster.MaximumHitPoints,
            monster.MaximumHitPoints,
            monster.Boss);

        Console.WriteLine("You searched the area and found a " + monster.Name + ".");

        BattleMonster battleSystem = new BattleMonster();
        battleSystem.StartBattle(player, battleMonster, player.CurrentLocation);

        if (battleMonster.CurrentHitPoints <= 0)
        {
            player.RecordEnemyDefeat(monster.ID);
            Console.WriteLine("Enemies of this type defeated: " + player.GetEnemyDefeats(monster.ID));
        }
    }
}