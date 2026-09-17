class Quest
{
    int ID;
    string Name;
    string Description;
    List<Weapon> Reward;

    public Quest(int id, string name, string description, List<Weapon> reward)
    {
        ID = id;
        Name = name;
        Description = description;
        Reward = reward;
    }

    public void StartQuest()
    {
        break;
    }

    public void FinishQuest()
    {
        break;
    }

    public void ViewQuests()
    {
        break;
    }
}