using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.IO;
using System.Linq;

public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager ()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            Console.Clear();
            string answer = "yes";

            while (answer != "6")
            {
                Console.WriteLine();
                DisplayPlayerInfo();
                Console.WriteLine();
                Console.WriteLine("Menu Options");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    CreateGoal();
                }

                else if (answer == "2")
                {
                    ListGoalDetails();
                }

                else if (answer == "3")
                {
                    Console.Write("What is the name of the goal file? ");
                    string file = Console.ReadLine();

                    SaveGoals(file);
                }

                else if (answer == "4")
                {
                    Console.Write("What is the filename for the goal file? ");
                    string file = Console.ReadLine();

                    LoadGoals(file);
                }

                else if (answer == "5")
                {
                    RecordEvent();
                }

                else
                {
                    Console.WriteLine();
                    Console.Write("You had entered an invalid choice.");
                    Console.WriteLine();
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
        }
        
        public void ListGoalName()
        {
            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.Write($"{i}. ");
                goal.DisplayGoalName();
                Console.WriteLine();
                i++;
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("The goals are:");

            int i = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{i}. {goal.GetDetailsString()}");
                i++;
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine();
            Console.WriteLine("The types of goal are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string answer = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string userInput = Console.ReadLine();
            int points = int.Parse(userInput);

            if (answer == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string userInput1 = Console.ReadLine();
                int target = int.Parse(userInput1);

                Console.Write("What is the bonus for accomplishing it that many times? ");
                string userInput2 = Console.ReadLine();
                int bonus = int.Parse(userInput2);

                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(cg);
            }

            else if (answer == "1")
            {
                SimpleGoal sg = new SimpleGoal(name, description, points);
                _goals.Add(sg);
            }

            else if (answer == "2")
            {
                EternalGoal eg = new EternalGoal(name, description, points);
                _goals.Add(eg);
            }

        }

        public void RecordEvent()
        {
            Console.WriteLine();
            Console.WriteLine("The goals are:");
            ListGoalName();
            Console.Write("Which goal did you accomplish? ");
            string userInput = Console.ReadLine();
            int answer = int.Parse(userInput);
            int points = _goals[answer-1].RecordEvent();
            _score = _score + points;
        
            Console.WriteLine($"Congratulations you have earned {points} points.");
            Console.WriteLine($"You now have {_score} points.");
        }

        public void SaveGoals(string file)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }

        }

        public void LoadGoals(string file)
        {
            string line1 = System.IO.File.ReadLines(file).First();
            int score = int.Parse(line1);
            _score = score;

            string[] lines = System.IO.File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string line3 = parts[3];
                    int points = int.Parse(line3);
                    string line4 = parts[4];
                    bool isComplete = bool.Parse(line4);

                    SimpleGoal sg = new SimpleGoal(name, description, points, isComplete);
                    _goals.Add(sg);

                }

                else if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string line3 = parts[3];
                    int points = int.Parse(line3);

                    EternalGoal eg = new EternalGoal(name, description, points);
                    _goals.Add(eg);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    string line3 = parts[3];
                    int points = int.Parse(line3);
                    string line4 = parts[4];
                    int bonus = int.Parse(line4);
                    string line5 = parts[5];
                    int target = int.Parse(line5);
                    string line6 = parts[6];
                    int amountCompleted = int.Parse(line6);

                    ChecklistGoal cg = new ChecklistGoal(name, description, points, bonus, target, amountCompleted);
                    _goals.Add(cg);

                }
                

            }
        }

    }