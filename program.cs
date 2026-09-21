using System;

static class Program
{
    static void Main()
    {
        Location currentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        while (true)
        {
            DisplayLocation(currentLocation);
            currentLocation = Move(currentLocation);

        }
    }
}
