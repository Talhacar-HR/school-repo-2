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


<<<<<<< Updated upstream
     static void DisplayLocation(Location location)
=======
    public static void DisplayLocation(Player player)
>>>>>>> Stashed changes
    {
        Console.WriteLine();
        Console.WriteLine("  P");
        Console.WriteLine("  A");
        Console.WriteLine("VFTGBS");
        Console.WriteLine("  H");
        Console.WriteLine("Your at " + location.Name);
        Console.WriteLine(location.Description);
    }

<<<<<<< Updated upstream
    static Location Move(Location currentlocation)
    {
        Console.WriteLine("Which way do you want to move N,E,S,W");
        string way = Console.ReadLine().ToUpper();

        Location destination = GetDestination(currentLocation, way);
    
=======
    public static Location Move(Player player)
    {
        Console.WriteLine("Which way do you want to move N,E,S,W");

        string way = Console.ReadLine().ToUpper();

        Location destination = GetDestination(player.CurrentLocation, way);

>>>>>>> Stashed changes
        if (destination == null)
        {
            Console.WriteLine("You can't go that way.");
            return currentLocation;
        }

        return destination;
    }

<<<<<<< Updated upstream
=======
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

>>>>>>> Stashed changes

    static Location GetDestination(Location currentlocation, string way)
    {
            if (way == "N")
            {
                return currentLocation.LocationToNorth;
            }
            else if (way == "S")
            {
                return currentLocation.LocationToSouth;
            }
            else if (way == "E")
            {
                return currentLocation.LocationToEast;
            }
            else if (way == "W")
            {
                return currentLocation.LocationToWest;
            }
            Console.WriteLine("You can't go that way.");
            return null;
            
            
    }







}


