using System;
using System.Collections.Generic;
using System.IO;


namespace EternalQuest
{
    class Program
    {

        private static List<Goal> _goals = new List<Goal>();
        private static int _score = 0;
        private static int _level = 1;
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                UpdateLevel();
                DisplayPlayerStatus();

                Console.WriteLine("\n Menu Options:");
                Console.WriteLine(" 1. Create New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");
                Console.Write("Select a Choice from the menu: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoals(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": RecordGoalEvent(); break;
                    case "6": running = false; break;
                    default: 
                        Console.WriteLine("Incorrect Choice, press any key to retry."); 
                        Console.ReadKey(); 
                        break; 
                }
            }
        }
        private static void UpdateLevel()
        {
            int calculatedLevel = 1 + (_score / 500);
            if (calculatedLevel < 1) calculatedLevel = 1;

            if (calculatedLevel > _level)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n Level Up! You reached Level {calculatedLevel}!");
                Console.ResetColor();
                TriggerSound(true);
                _level = calculatedLevel;
            }
            else if (calculatedLevel < _level)
            {
                _level = calculatedLevel;
            }
        }
        private static void DisplayPlayerStatus()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"            Eternal Quest Hero Dashboard         ");
            Console.WriteLine($"    Level: {_level} | Current Score: {_score} XP ");


            int nextLevelBase = (_level - 1) * 500;
            int progressInsideLevel = _score - nextLevelBase;
            int barTicks =(progressInsideLevel * 20) / 500;
            if (progressInsideLevel < 0) progressInsideLevel = 0;
            
            if (barTicks > 20) barTicks = 20;

            Console.Write(" Progress:  [");
            Console.Write(new string('#', barTicks));
            Console.Write(new string('-', 20 - barTicks));
            Console.WriteLine($"] {progressInsideLevel}/500 XP");
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
        }
        private static void CreateGoal()
        {
            Console.Clear();
            Console.WriteLine("The Types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine(" 4. Progressive Goal");
            Console.WriteLine(" Which type of goal would you like to create? ");
            string type = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine() ?? "0");

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points)); //separate the new and simplegoal
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                case "4":
                    Console.Write("What is the final metric target value (example, 25)? ");
                    double targetMetric = double.Parse(Console.ReadLine());
                    Console.Write("What is the unit of measure (example, Kilometers)? ");
                    string unit = Console.ReadLine();
                    _goals.Add(new ProgressiveGoal(name, description, points, targetMetric, unit)); //misspelling cuased error
                    break;
            }
        }
        private static void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("The goals are: ");
            if (_goals.Count == 0) 
            {
                Console.WriteLine(" No goals configured yet. ");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {_goals[i].GetDetailsString()}");
            }
            Console.WriteLine("\nPress any key to return to main menu.");
            Console.ReadKey();
        }

        private static void RecordGoalEvent()
        {
            Console.Clear();
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record event for!");
                Console.ReadKey();
                return;
            }
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {_goals[i].GetDetailsString()}");
            }

            Console.Write("Which goal did you accomplish? ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < _goals.Count)
            {
                Goal selectedGoal = _goals[index];
                
                if (selectedGoal is ProgressiveGoal progressive)
                {
                    Console.Write($"Enter progress to add more points ({progressive.Unit}): ");
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        int pointsEarned = selectedGoal.RecordEvent();
                        _score += pointsEarned;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n   Congratulations!! You earned {pointsEarned} points! ");
                        TriggerSound(true);
                    }
                }
                else
                {
                    int pointsEarned = selectedGoal.RecordEvent();
                    _score += pointsEarned;

                    Console.Clear();
                    if (pointsEarned > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n   Congratulations!! You earned {pointsEarned} points! ");
                        TriggerSound(true);
                    }
                
                    else
                    {
                    Console.WriteLine("\n This goal is already completed.");
                    }
                }
                Console.ResetColor();
                
            }
            Console.WriteLine("\n Press any key to continue. ");
            Console.ReadKey();
        }
        private static void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                outputFile.WriteLine(_level);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals Saved!!! Press any key to continue. ");
            Console.ReadKey();
        }
        private static void LoadGoals()
        {
            Console.Write($"What is the filename for your goal file? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found!");
                Console.ReadKey();
                return;
            }

            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _level = int.Parse(lines[1]);

            for (int i = 2; i < lines.Length; i++)
            {
                string line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(data[3]);
                    _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), isComplete));
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    int points = int.Parse(data[2]);
                    int bonus = int.Parse(data[3]);
                    int target = int.Parse(data[4]);
                    int completed = int.Parse(data[5]);
                    _goals.Add(new ChecklistGoal(data[0], data[1], points, target, bonus, completed));
                }
                else if (type == "ProgressiveGoal")
                {
                    int points = int.Parse(data[2]);
                    double targetMetric = double.Parse(data[3]);
                    string unit = data[4];
                    double currentProgress = double.Parse(data[5]);
                    _goals.Add(new ProgressiveGoal(data[0], data[1], points, targetMetric, unit, currentProgress));
                }
            }

            Console.WriteLine("Goals Loaded Successfully! ");
            Console.ReadKey();
        }

        private static void TriggerSound(bool levelUp)
        {
            if(levelUp && OperatingSystem.IsWindows())
            {
                Console.Beep(440, 150);
                Console.Beep(554, 150);
                Console.Beep(659, 150);
            }
        }
    }
}