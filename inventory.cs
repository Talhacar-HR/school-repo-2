using System;
using System.Collections.Generic;

public class Inventory
{
    public List<Weapon> inventory = new List<Weapon>();

    public void ViewInventory()
    {
        foreach (Weapon item in inventory)
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
        }
    }

    public void DropItem(Weapon droppedWeapon)
    {
        bool found = false;
        foreach (Weapon item in inventory)
        {
            if (item == droppedWeapon)
            {
                Console.WriteLine($"You dropped {item.Name}.");
                inventory.Remove(item);
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("No such item found in your inventory!");
        }
    }

    public void SwitchWeapon(Weapon switchingWeapon, Player currentPlayer)
    {
        foreach (Weapon item in inventory)
        {
            if (item == switchingWeapon)
            {
                currentPlayer.CurrentWeapon = item;
                Console.WriteLine($"You selected {item.Name}.");
                return;
            }
        }

        Console.WriteLine("That item is not in your inventory.");
    }

    public void UseItem(Weapon selectedWeapon)
    {
        Console.WriteLine("Item use is not implemented yet. This will be added once battle logic is finished.");
    }

}