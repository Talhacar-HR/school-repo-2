using System.Net.ServerSentEvents;

class Inventory
{
    public List<Weapon> inventory = [];
    public Weapon currentweapon; 

    public void ViewInventory()
    {
        Console.WriteLine(inventory);
    }

    public void AddItem(Weapon weapon)
    {
        ...
    }

    public void DropItem(Weapon weapon)
    {
        inventory.Remove(weapon);
    }

    public void SwitchWeapon(Weapon weapon)
    {
        ...
    }

    public void UseItem(Weapon weapon)
    {
        ...
    }

   






































































}