using System.Security;

class Inventory
{
    public List<Weapon> inventory = [];

    public void ViewInventory()
    {
        Console.WriteLine(inventory);
    }
    public void AddItem(Weapon weapon)
    {
        if (inventory.Count < 20)
        {
            inventory.Add(weapon);
            Console.WriteLine($"{weapon.Name} added to inventory.");
        }
        else
        {
            Console.WriteLine("Inventory is full.");
            // Further update needed, ask player if they want to drop/replace item from inventory to make space
        }
    }

    public void DropItem(Weapon weapon)
    {
        inventory.Remove($"{weapon}");
    }

    public void SwitchWeapon(Weapon weapon, Player player)
    {
        foreach(Weapon item in inventory)
        {
            if (item == weapon)
            {
                player.currentWeapon = item;
            }
        }
    }

    public void UseItem()
    {
        break;
    }

}