using System;

public class BattleMonster
{
    public bool InBattle = false;

    public void StartBattle(Player player, Monster monster, Location returnLocation)
    {
        InBattle = true;
        player.InBattle = true;

        Console.WriteLine($"\n--- A wild {monster.Name.ToUpper()} appears! ---");
        // Bijvoorbeeld "--- A wild SNAKE appears! ---"

        while (InBattle)
        {
            // 1. Toon de HUD (en Boss bar als het een boss is)
            DisplayBattleHUD(player, monster);

            // 2. Bepaal of de speler kan vluchten (underpowered / geen wapen)
            bool isUnderpowered = (player.CurrentWeapon == null) || (monster.MaximumDamage >= player.CurrentHitPoints);

            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1: Attack");
            if (isUnderpowered)
            {
                Console.WriteLine("2: Flee (You feel underpowered!)");
            }

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Speler valt aan
                int weaponDmg = player.CurrentWeapon != null ? player.CurrentWeapon.MaximumDamage : 0;
                int playerDmg = player.Attack + weaponDmg;
                monster.CurrentHitPoints -= playerDmg;
                Console.WriteLine($"\nYou hit the {monster.Name} for {playerDmg} damage!");

                // Monster verslagen?
                if (monster.CurrentHitPoints <= 0)
                {
                    Console.WriteLine($"\nYou defeated the {monster.Name}!");
                    player.Level++;
                    Console.WriteLine($"Level Up! You are now level {player.Level}!");

                    InBattle = false;
                    player.InBattle = false;
                    break;
                }

                // Monster slaat terug
                Console.WriteLine($"The {monster.Name} hits you for {monster.MaximumDamage} damage!");
                player.CurrentHitPoints -= monster.MaximumDamage;

                // Speler verslagen?
                if (player.CurrentHitPoints <= 0)
                {
                    Console.WriteLine("\nYou fainted and woke up at home...");
                    player.CurrentHitPoints = player.MaximumHitPoints;
                    player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
                    InBattle = false;
                    player.InBattle = false;
                    return;
                }
            }
            else if (choice == "2" && isUnderpowered)
            {
                Console.WriteLine("\nYou successfully fled from battle!");
                InBattle = false;
                player.InBattle = false;
                player.CurrentLocation = returnLocation;
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        // Na winst: keer terug naar de vorige locatie
        player.CurrentLocation = returnLocation;
        Console.WriteLine($"You returned to {returnLocation.Name}.");
    }

    private void DisplayBattleHUD(Player player, Monster monster)
    {
        Console.WriteLine("\n================ BATTLE HUD ================");
        Console.WriteLine($"Player: {player.Name} | HP: {player.CurrentHitPoints}/{player.MaximumHitPoints} | Level: {player.Level}");

        if (monster.Boss)
        {
            Console.WriteLine($"[BOSS] {monster.Name.ToUpper()} | HP: {monster.CurrentHitPoints}/{monster.MaximumHitPoints}");
            DrawBossBar(monster.CurrentHitPoints, monster.MaximumHitPoints);
        }
        else
        {
            Console.WriteLine($"Enemy: {monster.Name} | HP: {monster.CurrentHitPoints}/{monster.MaximumHitPoints} | ATK: {monster.MaximumDamage}");
        }
        Console.WriteLine("============================================");
    }

    private void DrawBossBar(int current, int max)
    {
        int length = 20;
        int filled = (int)((double)current / max * length);
        if (filled < 0) filled = 0;
        string bar = new string('=', filled) + new string('-', length - filled);
        Console.WriteLine($"BOSS BAR: [{bar}]");
    }
}