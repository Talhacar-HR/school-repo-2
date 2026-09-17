public static class World
{

    public static readonly List<Weapon> Weapons = new List<Weapon>();
    public static readonly List<Monster> Monsters = new List<Monster>();
    public static readonly List<Quest> Quests = new List<Quest>();
    public static readonly List<Location> Locations = new List<Location>();
    public static readonly Random RandomGenerator = new Random();

    public const int WEAPON_ID_RUSTY_SWORD = 1;
    public const int WEAPON_ID_CLUB = 2;
    public const int WEAPON_ID_IRON_SWORD = 3;
    public const int WEAPON_ID_COIN_POUCH = 4;
    public const int WEAPON_ID_PROOF_OF_GRIT = 5;
    public const int WEAPON_ID_FLASK_OF_HEALING = 6;
    public const int WEAPON_ID_POTION_OF_HEALING = 7;
    public const int WEAPON_ID_VIAL_OF_HEALING = 8;
    public const int WEAPON_ID_FLASK_OF_STRENGTH = 9;
    public const int WEAPON_ID_POTION_OF_STRENGTH = 10;
    public const int WEAPON_ID_LEATHER_TUNIC = 11;
    public const int WEAPON_ID_IRON_CHESTPLATE = 12;
    public const int WEAPON_ID_MONSTER_ARMOR = 13;

    public const int MONSTER_ID_RAT = 1;
    public const int MONSTER_ID_SNAKE = 2;
    public const int MONSTER_ID_GIANT_SPIDER = 3;

    public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
    public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
    public const int QUEST_ID_COLLECT_SPIDER_SILK = 3;

    public const int LOCATION_ID_HOME = 1;
    public const int LOCATION_ID_TOWN_SQUARE = 2;
    public const int LOCATION_ID_GUARD_POST = 3;
    public const int LOCATION_ID_ALCHEMIST_HUT = 4;
    public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
    public const int LOCATION_ID_FARMHOUSE = 6;
    public const int LOCATION_ID_FARM_FIELD = 7;
    public const int LOCATION_ID_BRIDGE = 8;
    public const int LOCATION_ID_SPIDER_FIELD = 9;

    static World()
    {
        PopulateWeapons();
        PopulateMonsters();
        PopulateQuests();
        PopulateLocations();
    }

    public static void PopulateWeapons()
    {
        Weapons.Add(new Weapon(WEAPON_ID_RUSTY_SWORD, "Rusted Sword", 5, 0, 0, true, false, "WEAPON", "An old, rusted sword. Raises damage by 10."));
        Weapons.Add(new Weapon(WEAPON_ID_CLUB, "Club", 10, 0, 0, true, false, "WEAPON", "A trusty wooden club. Raises damage by 10."));
        Weapons.Add(new Weapon(WEAPON_ID_IRON_SWORD, "Iron Sword", 10, 0, 20, true, false, "WEAPON", "An excellent iron sword. Raises damage by 10, and gives 20 CRIT."));
        Weapons.Add(new Weapon(WEAPON_ID_COIN_POUCH, "Coin Pouch", 0, 0, 0, false, false, "OTHER", "A pouch with coins. Spend wisely."));
        Weapons.Add(new Weapon(WEAPON_ID_PROOF_OF_GRIT, "Proof of Grit", 0, 0, 0, false, false, "OTHER", "A Proof of Grit obtained by completely quests. Needed to pass the guard."));
        Weapons.Add(new Weapon(WEAPON_ID_FLASK_OF_HEALING, "Flask of Healing", 0, 15, 0, false, true, "OTHER", "A flask of healing. Heals 15 HP."));
        Weapons.Add(new Weapon(WEAPON_ID_POTION_OF_HEALING, "Potion of Healing", 0, 25, 0, false, true, "OTHER", "A potion of healing. Heals 25 HP."));
        Weapons.Add(new Weapon(WEAPON_ID_VIAL_OF_HEALING, "Vial of Healing", 0, 50, 0, false, true, "OTHER", "A vial of healing. Heals 50 HP."));
        Weapons.Add(new Weapon(WEAPON_ID_FLASK_OF_STRENGTH, "Flask of Strength", 5, 0, 0, false, true, "OTHER", "A flask of strength. Raises attack by 5 for three attacks."));
        Weapons.Add(new Weapon(WEAPON_ID_POTION_OF_STRENGTH, "Potion of Strength", 10, 0, 0, false, true, "OTHER", "A potion of strength. Raises attack by 10 for two attacks."));
        Weapons.Add(new Weapon(WEAPON_ID_LEATHER_TUNIC, "Leather Tunic", 0, 10, 0, true, false, "ARMOR", "A soft leather tunic. Raises Max HP by 10."));
        Weapons.Add(new Weapon(WEAPON_ID_IRON_CHESTPLATE, "Iron Chestplate", 0, 30, 0, true, false, "ARMOR", "A sturdy iron chestplate. Raises Max HP by 30."));
        Weapons.Add(new Weapon(WEAPON_ID_MONSTER_ARMOR, "Monster Armor", 0, 20, 20, true, false, "ARMOR", "A handcrafted set of monster armor. Raises Max HP by 20 and gives 20 CRIT."));
    }

    public static void PopulateMonsters()
    {
        Monster rat = new Monster(MONSTER_ID_RAT, "rat", 5, 30, 30);


        Monster snake = new Monster(MONSTER_ID_SNAKE, "snake", 8, 20, 20);


        Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "giant spider", 10, 40, 40);

        Monsters.Add(rat);
        Monsters.Add(snake);
        Monsters.Add(giantSpider);
    }

    public static void PopulateQuests()
    {
        Quest clearAlchemistGarden =
            new Quest(
                QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Clear the alchemist's garden",
                "Kill 3 rats in the alchemist's garden",
                new List<Weapon> { WeaponByID(WEAPON_ID_PROOF_OF_GRIT) }
                );

        Quest clearFarmersField =
            new Quest(
                QUEST_ID_CLEAR_FARMERS_FIELD,
                "Clear the farmer's field",
                "Kill 3 snakes in the farmer's field",
                new List<Weapon> {WeaponByID(WEAPON_ID_PROOF_OF_GRIT)});

        Quest clearSpidersForest =
            new Quest(
                QUEST_ID_COLLECT_SPIDER_SILK,
                "Collect spider silk",
                "Kill 3 spiders in the spider forest",
                new List<Weapon> {WeaponByID(WEAPON_ID_PROOF_OF_GRIT)});

        Quests.Add(clearAlchemistGarden);
        Quests.Add(clearFarmersField);
        Quests.Add(clearSpidersForest);
    }

    public static void PopulateLocations()
    {
        // Create each location
        Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.", null, null);

        Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.", null, null);

        Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.", null, null);
        alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

        Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.", null, null);
        alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

        Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.", null, null);
        farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

        Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.", null, null);
        farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

        Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", null, null);

        Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.", null, null);
        bridge.QuestAvailableHere = QuestByID(QUEST_ID_COLLECT_SPIDER_SILK);

        Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.", null, null);
        spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

        // Link the locations together
        home.LocationToNorth = townSquare;

        townSquare.LocationToNorth = alchemistHut;
        townSquare.LocationToSouth = home;
        townSquare.LocationToEast = guardPost;
        townSquare.LocationToWest = farmhouse;

        farmhouse.LocationToEast = townSquare;
        farmhouse.LocationToWest = farmersField;

        farmersField.LocationToEast = farmhouse;

        alchemistHut.LocationToSouth = townSquare;
        alchemistHut.LocationToNorth = alchemistsGarden;

        alchemistsGarden.LocationToSouth = alchemistHut;

        guardPost.LocationToEast = bridge;
        guardPost.LocationToWest = townSquare;

        bridge.LocationToWest = guardPost;
        bridge.LocationToEast = spiderField;

        spiderField.LocationToWest = bridge;

        // Add the locations to the static list
        Locations.Add(home);
        Locations.Add(townSquare);
        Locations.Add(guardPost);
        Locations.Add(alchemistHut);
        Locations.Add(alchemistsGarden);
        Locations.Add(farmhouse);
        Locations.Add(farmersField);
        Locations.Add(bridge);
        Locations.Add(spiderField);
    }

    public static Location LocationByID(int id)
    {
        foreach (Location location in Locations)
        {
            if (location.ID == id)
            {
                return location;
            }
        }

        return null;
    }

    public static Weapon WeaponByID(int id)
    {
        foreach (Weapon item in Weapons)
        {
            if (item.ID == id)
            {
                return item;
            }
        }

        return null;
    }

    public static Monster MonsterByID(int id)
    {
        foreach (Monster monster in Monsters)
        {
            if (monster.ID == id)
            {
                return monster;
            }
        }

        return null;
    }

    public static Quest QuestByID(int id)
    {
        foreach (Quest quest in Quests)
        {
            if (quest.ID == id)
            {
                return quest;
            }
        }

        return null;
    }
}