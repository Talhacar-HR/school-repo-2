public class BattleMonster
{

    bool in_battle = false;

    public void location_to_battle_monster(Location playerLocation)
    {
        if (playerLocation.ID == world.LOCATION_ID_FARM_FIELD)
        {
            in_battle = true;
        }
    }
    // enemy_power = enemy_damage * 2;

    // underpowered = enemy_power >= player_health 
    // if damage monster > player_health

    // if player in battle and underpowered = true
    //     giveoption_toflee()
}

