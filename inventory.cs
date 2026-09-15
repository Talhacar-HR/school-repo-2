using System.Security;

class Inventory
{
    public List<Weapon> inventory = [];

    public void ViewInventory()
    {
        foreach(Weapon item in inventory)
        {
            Console.WriteLine(item.Name);
        }
    }
    public void AddItem(Weapon addedWeapon)
    {
        if (inventory.Count < 20)
        {
            inventory.Add(addedWeapon);
            Console.WriteLine($"{addedWeapon.Name} added to inventory.");
        }
        else
        {
            Console.WriteLine("Inventory is full.");
            // Further update needed, ask player if they want to drop/replace item from inventory to make space
        }
    }

    public void DropItem(Weapon droppedWeapon)
    {
        inventory.Remove($"{droppedWeapon}");
    }

    public void SwitchWeapon(Weapon selectedWeapon, Player currentPlayer)
    {
        foreach(Weapon item in inventory)
        {
            if (item == selectedWeapon)
            {
                currentPlayer.CurrentWeapon = item;
            }
        }
    }

    public void UseItem(Weapon selectedWeapon)
    {
        break;
    }

}