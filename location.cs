public class Location
{
    public int ID;
    
    public string Name;

    public string Description;

    public Quest QuestAvailableHere;

    public Monster MonsterLivingHere;

    public Location LocationToNorth;

    public Location LocationToEast;

    public Location LocationToSouth;

    public Location LocationToWest;

    public Location(int id, string name, string description, Quest questavailablehere, Monster monsterlivinghere)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestAvailableHere = questavailablehere;
        MonsterLivingHere = monsterlivinghere;
    }

    public static void DisplayLocation(Player player)
    {
        Console.WriteLine();
        Console.WriteLine("  P");
        Console.WriteLine("  A");
        Console.WriteLine("VFTGBS");
        Console.WriteLine("  H");
        Console.WriteLine("Your at " + player.CurrentLocation.Name);
        Console.WriteLine(player.CurrentLocation.Description);
        Console.WriteLine($"HP: {player.CurrentHitPoints}/{player.MaximumHitPoints}");
    }

    static Location Move(Player player)
    {
        if(player.CurrentLocation.ID == World.LOCATION_ID_TOWN_SQUARE)
        {
            Console.WriteLine("Which way do you want to move N,E,S,W, or R to rest");
        }
        else 
        {
            Console.WriteLine("Which way do you want to move N,E,S,W");
        }

        string way = Console.ReadLine().ToUpper();

    public static Location Move(Player player)
    {
        Console.WriteLine("Which way do you want to move N, E, S, W");

        string way = Console.ReadLine().ToUpper();

        Location destination = GetDestination(player.CurrentLocation, way);

        if (destination == null)
        {
            Console.WriteLine("You can't go that way.");
            return player.CurrentLocation;
        }

        return destination;
    }

    public static void Rest(Player player)
    {
        if (player.CurrentLocation.ID == World.LOCATION_ID_TOWN_SQUARE)
        {
            player.CurrentHitPoints = player.MaximumHitPoints;
            Console.WriteLine("You rest at the town square. Your HP is fully restored.");
        }
        else
        {
            Console.WriteLine("You can only rest at the town square.");
        }
    }

    static Location GetDestination(Location currentlocation, string way)
    {
            if (way == "N")
            {
                return currentlocation.LocationToNorth;
            }
            else if (way == "S")
            {
                return currentlocation.LocationToSouth;
            }
            else if (way == "E")
            {
                return currentlocation.LocationToEast;
            }
            else if (way == "W")
            {
                return currentlocation.LocationToWest;
            }
            Console.WriteLine("You can't go that way.");
            return null;
    }
}