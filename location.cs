public class Location
{
    public int ID;
    public string Name;

    public string Description;


    public Quest QuestAvailableHere;

    public Monster MonsterLivigHere;

    public Location LocationToNorth;

    public Location LocationToEast;

    public Location LocationToSouth;

    public Location LocationToWest;

    public Location(int id, string name,string description, Quest questavailablehere, Monster MonsterLivigHere, Location locationtonorth, Location locationtoeast, Location locationtosouth, Location locationtowest)
    {
    ID = id;
    Name = name;
    Description = description;
    QuestAvailableHere = questavailablehere;
    MonsterLivigHere = monsterLivigHere;
    LocationToNorth = locationtonorth;
    LocationToEast = locationtoeast;
    LocationToSouth = locationtosouth;
    LocationToWest = locationtowest;
    }
}