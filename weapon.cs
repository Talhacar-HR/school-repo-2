public class Weapon
{
	public int ID;
	public string Name;
	public int MaximumDamage;
    public int Health;
    public int Crit;
    public int Amount;
    public bool Equippable;
    public bool Usable;

	public Weapon(int id, string name, int damage, int health, int crit, int amount, bool equippable, bool usable)
	{
		ID = id;
		Name = name;
		MaximumDamage = damage;
        Health = health;
        Crit = crit;
        Amount = amount;
        Equippable = equippable;
        Usable = usable;
	}
}