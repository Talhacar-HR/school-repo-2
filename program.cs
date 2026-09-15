using System;
static class Program
{
    static void Main()
    { 
        Console.WriteLine("Wich way doe you want to move N,E,S,W");
        string way = Console.ReadLine().ToUpper();
    
        int location_y = -1;
        int location_x = 0;
        
        if (way == "N")
        {
            location_y += 1;
        }
        if (way == "S")
        {
            location_y -= 1;
        }
        if (way == "E")
        {
            location_x += 1;
        }
        if (way == "W")
        {
            location_x -= 1;
        }

        if (location_x == 0 && location_y == -1)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Your house");
        }
        else if (location_x == 0 && location_y == 0)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Town square");
        }
        else if (location_x == -1 && location_y == 0)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Farmer");
        }
        else if (location_x == -2 && location_y == 0)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Farmer’s field");
        }
        else if (location_x == 0 && location_y == 2)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Alchemist’s hut");
        }
        else if (location_x == 0 && location_y == 3)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Alchemist’s garden");
        }
        else if (location_x == 1 && location_y == 0)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Guard post");
        }
        else if (location_x == 2 && location_y == 0)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Bridge");
        }
        else if (location_x == 3 && location_y == 0)
        {    
            Console.WriteLine("  P");
            Console.WriteLine("  A");
            Console.WriteLine("VFTGBS");
            Console.WriteLine("  H");
            Console.WriteLine("Your at Spiderman forest");
        }
    }
}