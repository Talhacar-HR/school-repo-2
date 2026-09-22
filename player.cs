public class Player
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Attack;
    public bool InBattle;
    public List<Inventory> Inventory;
    public Weapon CurrentWeapon;
    public Weapon CurrentArmor;
    public Location CurrentLocation;

    public Player(string name, int currentHitPoints, int maximumHitPoints)
    {
        Name = name;
        CurrentHitPoints = currentHitPoints;
        MaximumHitPoints = maximumHitPoints;
        InBattle = false;
        Inventory = new List<Inventory>();
    }
}