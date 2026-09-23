using System;

static class Program
{
    static void Main()
    {
        Player player = new Player("Hero", 50, 50);
        player.CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD);
        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);

        bool quit = false;

        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Complete all three quests and return to the guard post.");

        while (!quit && !HasWon(player))
        {
            Console.WriteLine();
            Location.DisplayLocation(player);
            ShowCommands(player);
            Console.Write("What do you want to do? ");

            string command = (Console.ReadLine() ?? "").Trim().ToLower();

            if (command == "move")
            {
                player.CurrentLocation = Location.Move(player);
            }
            else if (command == "rest")
            {
                Location.Rest(player);
            }
            else if (command == "map")
            {
                Location.DisplayLocation(player, true);
            }
            else if (command == "search")
            {
                Monster.SearchForMonster(player);
            }
            else if (command == "talk")
            {
                TalkToNpc(player);
            }
            else if (command == "quests")
            {
                Quest.ViewQuests();
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("That is not a valid command.");
            }
        }

        if (HasWon(player))
        {
            Console.WriteLine("You completed all quests and reached the guard post. You win!");
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }

    static void ShowCommands(Player player)
    {
        Console.WriteLine("Available commands: move, map, quests, quit");

        if (player.CurrentLocation.MonsterLivingHere != null)
        {
            Console.WriteLine("You can also 'search' for monsters here!");
        }

        if (player.CurrentLocation.QuestAvailableHere != null)
        {
            Console.WriteLine("You can also 'talk' to the NPC here!");
        }

        if (player.CurrentLocation.ID == World.LOCATION_ID_TOWN_SQUARE)
        {
            Console.WriteLine("You can also 'rest' here!");
        }
    }


    static void TalkToNpc(Player player)
    {
        Quest quest = player.CurrentLocation.QuestAvailableHere;

        if (quest == null)
        {
            Console.WriteLine("There is nobody to talk to here.");
            return;
        }

        if (quest.IsCompleted)
        {
            Console.WriteLine("You already completed this quest.");
            return;
        }

        if (!quest.IsActive)
        {
            Console.WriteLine("The NPC offers you this quest:");
            Quest.ViewQuest(quest);
            Console.Write("Do you accept the quest? (y/n): ");

            string answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer == "y" || answer == "yes")
            {
                Quest.StartQuest(quest);
            }
            else
            {
                Console.WriteLine("You refused the quest.");
            }

            return;
        }

        Console.WriteLine("You have already accepted this quest.");

        if (ObjectiveIsComplete(player, quest.ID))
        {
            Quest.FinishQuest(player, quest);
        }
        else
        {
            Console.WriteLine("You have not finished the quest objective yet.");
        }
    }

    static bool ObjectiveIsComplete(Player player, int questId)
    {
        if (questId == World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN)
        {
            return player.GetEnemyDefeats(World.MONSTER_ID_RAT) >= 3;
        }

        if (questId == World.QUEST_ID_CLEAR_FARMERS_FIELD)
        {
            return player.GetEnemyDefeats(World.MONSTER_ID_SNAKE) >= 3;
        }

        if (questId == World.QUEST_ID_COLLECT_SPIDER_SILK)
        {
            return player.GetEnemyDefeats(World.MONSTER_ID_GIANT_SPIDER) >= 3;
        }

        return false;
    }

    static bool HasWon(Player player)
    {
        bool questsCompleted = World.QuestByID(World.QUEST_ID_CLEAR_ALCHEMIST_GARDEN).IsCompleted
            && World.QuestByID(World.QUEST_ID_CLEAR_FARMERS_FIELD).IsCompleted
            && World.QuestByID(World.QUEST_ID_COLLECT_SPIDER_SILK).IsCompleted;

        return questsCompleted && player.CurrentLocation.ID == World.LOCATION_ID_GUARD_POST;
    }
}