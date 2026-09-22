using System;

static class Program
{
    static void Main()
    {
        // Maak de speler aan en geef een startwapen
        Player player = new Player("Hero", 50, 50);
        player.CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD);
        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        BattleMonster battleSystem = new BattleMonster();

        while (true)
        {
            Location previousLocation = player.CurrentLocation;

            Location.DisplayLocation(player.CurrentLocation);
            player.CurrentLocation = Location.Move(player);

            // Controleer of er een monster op de nieuwe locatie is
            if (player.CurrentLocation.MonsterLivingHere != null)
            {
                // Maak een kopie zodat de startstats gereset zijn
                Monster baseMonster = player.CurrentLocation.MonsterLivingHere;
                Monster battleMonster = new Monster(
                    baseMonster.ID,
                    baseMonster.Name,
                    baseMonster.MaximumDamage,
                    baseMonster.MaximumHitPoints,
                    baseMonster.MaximumHitPoints,
                    baseMonster.Boss
                );

                battleSystem.StartBattle(player, battleMonster, previousLocation);
            }
        }
    }
}