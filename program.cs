using System;

static class Program
{
    static void Main()
    {
        Location currentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        while (true)
        {
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
