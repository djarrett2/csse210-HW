public class EternalQuest
    {
        private List<Goal> _goals;
        private int _totalScore;

        public EternalQuest()
        {
            _goals = new List<Goal>();
            _totalScore = 0;
        }

        public void Run()
        {
            bool running = true;
            
            while (running)
            {
                Console.WriteLine($"\nYou have {_totalScore} points.\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoals();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("You did good today. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string type = Console.ReadLine();
            
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            
            Goal newGoal = null;
            
            switch (type)
            {
                case "1":
                    newGoal = new Simple(name, description, points);
                    break;
                case "2":
                    newGoal = new Eternal(name, description, points);
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    newGoal = new Checklist(name, description, points, targetCount, bonusPoints);
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    return;
            }
            
            if (newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("Goal created successfully!");
            }
        }

        private void ListGoals()
        {
            Console.WriteLine("Your goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
            }
        }

        private void RecordEvent()
        {
            ListGoals();
            Console.Write("Which goal did you accomplish? ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;
            
            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _totalScore += pointsEarned;
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_totalScore} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
            }
        }

        private void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_totalScore);
                
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.SaveToString());
                }
            }
            
            Console.WriteLine("Goals saved successfully!");
        }

        private void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }
            
            _goals.Clear();
            
            using (StreamReader reader = new StreamReader(filename))
            {
                _totalScore = int.Parse(reader.ReadLine());
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] data = parts[1].Split(',');
                    
                    Goal goal = null;
                    
                    switch (goalType)
                    {
                        case "SimpleGoal":
                            goal = new Simple(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
                            break;
                        case "EternalGoal":
                            goal = new Eternal(data[0], data[1], int.Parse(data[2]));
                            break;
                        case "ChecklistGoal":
                            goal = new Checklist(data[0], data[1], int.Parse(data[2]), 
                                int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
                            break;
                    }
                    
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            
            Console.WriteLine("Goals loaded successfully!");
        }
    }