using System.ComponentModel;

public class Weapon
{
	public int ID;
	public string Name;
	public int MaximumDamage;
    public int Health;
    public int Crit;
    public bool Equippable;
    public bool Usable;
	public string Description;

	public Weapon(int id, string name, int damage, int health, int crit, bool equippable, bool usable, string description)
	{
		ID = id;
		Name = name;
		MaximumDamage = damage;
        Health = health;
        Crit = crit;
        Equippable = equippable;
        Usable = usable;
		Description = description;
	}
}