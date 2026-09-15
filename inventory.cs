using System.Security;

class Inventory
{
    public List<Weapon> inventory = [];

    public void ViewInventory()
    {
        foreach(Weapon item in inventory)
        {
            Console.WriteLine(item.Name);
            // Needs testing to add more info eg description, stats etc
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
    // What do we want to send from program.cs? The entire object selected in the drop item menu, or just the name?
    // In world.cs there is a function called "WeaponByID", best to use that maybe?
    {
        bool found = false;
        foreach (Weapon item in inventory)
        {
            if (item == droppedWeapon)
            {
                Console.WriteLine($"You dropped {item.Name}.");
                inventory.Remove(item);
                found == true;
                break;
            }
        }
        if (found == false)
        {
            Console.WriteLine("No such item found in your inventory!");
        }
    }

    public void SwitchWeapon(Weapon selectedWeapon, Player currentPlayer)
    // Needs to be tested; is "Player currentPlayer" neccesary?
    // Also needs further updating to deny usage when in a battle
    {
        foreach(Weapon item in inventory)
        {
            if (item == selectedWeapon)
            {
                currentPlayer.CurrentWeapon = item;
                Console.WriteLine($"You selected {item.Name}.");
            }
        }
    }

    public void UseItem(Weapon selectedWeapon)
    {
        // Cannot be implemented yet; battle logic needs to be added first
        break;
    }

}