using System;

static class Program
{
    static void Main()
    {
        Location currentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at " + currentLocation.Name);
            Console.WriteLine(currentLocation.Description);

            Console.WriteLine("Which way do you want to move N,E,S,W");
            string way = Console.ReadLine().ToUpper();

            Location destination = null;

            if (way == "N")
            {
                destination = currentLocation.LocationToNorth;
            }
            else if (way == "S")
            {
                destination = currentLocation.LocationToSouth;
            }
            else if (way == "E")
            {
                destination = currentLocation.LocationToEast;
            }
            else if (way == "W")
            {
                destination = currentLocation.LocationToWest;
            }

            if (destination == null)
            {
                Console.WriteLine("You can't go that way.");
            }
            else
            {
                currentLocation = destination;
            }
        }
    }
}
