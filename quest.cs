public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public List<Weapon> Reward;
    public bool IsActive;
    public bool IsCompleted;

    public Quest(int id, string name, string description, List<Weapon> reward)
    {
        ID = id;
        Name = name;
        Description = description;
        Reward = reward ?? new List<Weapon>();
        IsActive = false;
        IsCompleted = false;
    }

    public static void ViewQuest(Quest quest)
    {
        if (quest == null)
        {
            Console.WriteLine("Quest not found.");
            return;
        }

        Console.WriteLine($"\nQuest #{quest.ID}: {quest.Name}");
        Console.WriteLine($"Status: {(quest.IsCompleted ? "Completed" : quest.IsActive ? "In progress" : "Available")}");
        Console.WriteLine(quest.Description);

        if (quest.Reward != null && quest.Reward.Count > 0)
        {
            Console.Write("Reward: ");
            for (int i = 0; i < quest.Reward.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }

                Console.Write(quest.Reward[i].Name);
            }

            Console.WriteLine();
        }
    }

    public static void ViewQuests()
    {
        foreach (Quest quest in World.Quests)
        {
            ViewQuest(quest);
        }
    }

    public static void StartQuest(Quest quest)
    {
        if (quest == null)
        {
            Console.WriteLine("Quest not found.");
            return;
        }

        if (quest.IsCompleted)
        {
            Console.WriteLine($"You already completed the quest: {quest.Name}.");
            return;
        }

        quest.IsActive = true;
        Console.WriteLine($"You started the quest: {quest.Name}");
    }

    public static void FinishQuest(Player player, Quest quest)
    {
        if (quest == null)
        {
            Console.WriteLine("Quest not found.");
            return;
        }

        if (!quest.IsActive)
        {
            Console.WriteLine($"You have not started the quest: {quest.Name}.");
            return;
        }

        quest.IsCompleted = true;
        quest.IsActive = false;

        Console.WriteLine($"Quest complete: {quest.Name}");

        if (quest.Reward != null && quest.Reward.Count > 0)
        {
            Console.WriteLine("Rewards earned:");
            foreach (Weapon reward in quest.Reward)
            {
                Console.WriteLine($"- {reward.Name}");
            }
        }
    }
}