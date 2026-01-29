using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private string _fileName;
    private int _goalList;
    private int _score;
    private string _level = "Just Started Mouse";
    private bool _isNotFirst = false;
    private bool _isComplete;

    // Constructor
    public GoalManager()
    {
        _score = 0;
    }

    // Called in the Program.cs file, and runs the menu loop.
    public void Start()
    {
        string menuChoice = "";
        Console.WriteLine("");

        do {
            Console.WriteLine($"You have {_score} points.");

            Console.WriteLine("");
            Console.WriteLine("    Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. View Current Level");
            Console.WriteLine("7. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if(menuChoice == "1")
            {
                Console.WriteLine("");

                CreateGoal();
                Console.WriteLine("");
                Console.WriteLine("");
            }

            else if (menuChoice == "2")
            {
                Console.WriteLine("");
                
                ListGoalDetails();
                Console.WriteLine("");
                Console.WriteLine("");
            }

            else if (menuChoice == "3")
            {
                Console.WriteLine("");

                SaveGoals();
                Console.WriteLine("");
                Console.WriteLine("");
            }

            else if (menuChoice == "4")
            {
                Console.WriteLine("");

                LoadGoals();
                Console.WriteLine("");
                Console.WriteLine("");
            }

            else if (menuChoice == "5")
            {
                Console.WriteLine("");

                RecordEvent();
                Console.WriteLine("");
                Console.WriteLine("");
            }

            else if (menuChoice == "6")
            {
                Console.WriteLine("");
                Console.WriteLine($"Current Level: {_level}");
                Console.WriteLine("");
            }

            else if (menuChoice == "7")
            {
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, that is not one of the Menu options. Please select again.");
                Console.WriteLine("");
                Console.WriteLine("");
            }
        } while (menuChoice != "7");
    }

    // Lists the names of each of the goals, used when Menu Option #5 (Record Event) is selected.
    public void ListGoalNames()
    {
        int list = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(list + ". " + goal.GetName());
            list++;
        }
    }

    // Lists the details of each goal, used when Menu Option #2 (List Goals) is selected.
    public void ListGoalDetails()
    {
        _goalList = _goals.Count();

        if(_goalList == 0)
        {
            Console.WriteLine("You haven't created any goals yet.\nSelect option #1 on the Menu Options to start.");
            Console.WriteLine("");
        }

        else    
        {
            int list = 1;

            Console.WriteLine("Your goals are:");

            foreach (Goal goal in _goals)
            {
                Console.WriteLine(list + ". " + goal.GetDetailsString());
                list++;
            }
        }
    }

    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the goal list.
    public void CreateGoal()
    {
        string newGoalChoice = "";
        string goalName = "";
        string goalDescription = "";
        string goalPoints = "";

        do {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Return to the Main Menu");
            Console.WriteLine("");
            Console.Write("Which type of goal would you like to create? ");
            newGoalChoice = Console.ReadLine();

            if(newGoalChoice == "1")
            {
                Console.WriteLine("");
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of this goal? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                goalPoints = Console.ReadLine();
                _isComplete = false;
                _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints, _isComplete));
                newGoalChoice = "4";
            }

            else if (newGoalChoice == "2")
            {
                Console.WriteLine("");
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of this goal? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                goalPoints = Console.ReadLine();
                _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                newGoalChoice = "4";
            }

            else if (newGoalChoice == "3")
            {
                Console.WriteLine("");
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();
                Console.Write("What is a short description of this goal? ");
                goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                goalPoints = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string target = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonus = Console.ReadLine();
                int amountCompleted = 0;
                _goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, amountCompleted, target, bonus));
                newGoalChoice = "4";
            }

            else if (newGoalChoice == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Returning to the Main Menu...");
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("");
                Console.WriteLine("Sorry, that is not one of the Create New Goal options. Please select again.");
                Console.WriteLine("");
                Console.WriteLine("");
            }

        } while (newGoalChoice != "4");
    }

    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {
        int recordEventChoice = -1;
        string pastLevel;
        string inspiration;

        // List of the different inspirations the user can unlock, when their score reaches a certain amount.
        List<string> inspirations = new List<string>{"The First of Many", "The Momentum is Building", "On the Road to Success", "One Step At a Time", "Keep Going!", "Amazing!", "Awesomely Awesome!", "You Can Do This!", "Fantastic!", "You've Got This!", "Look How Far You've Come!"};

        // List of the different levels the user can reach, when their score is in a certain range.
        List<string> levels = new List<string>{"Paper Squirrel", "Wooden Rabbit", "Copper Fox", "Iron Lion", "Bronze Hippo", "Steel Elephant", "Crystal Crocodile", "Silver Scorpion", "Gold Pegasus", "Diamond Dragon", "Platinum Phoenix"};

        _goalList = _goals.Count();

        if(_goalList == 0)
        {
            recordEventChoice = 1;
            Console.WriteLine("You haven't created any goals yet.\nSelect option #1 on the Menu Options to start.");
            Console.WriteLine("");
        }

        else
        {
            while(recordEventChoice < 1 || recordEventChoice > _goalList)
            {
                Console.WriteLine("");
                Console.WriteLine("The goals are:");
                
                ListGoalNames();
                
                Console.WriteLine("");
                Console.Write("Which goal did you accomplish? ");
                recordEventChoice = int.Parse(Console.ReadLine());
                
                if(recordEventChoice < 1 || recordEventChoice > _goalList)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, that is not one of the Record Event options. Please select again.");
                    Console.WriteLine("");
                }
            }

            if(!_isNotFirst)
            {
                inspiration = inspirations[0];
                _isNotFirst = true;
            }

            else
            {
                inspiration = inspirations[1];
            }

            if(_score <= 100)
            {
                pastLevel = _level;
                _level = levels[0];
            }

            else if(_score >= 101 && _score <= 200)
            {
                pastLevel = _level;
                _level = levels[1];
                inspiration = inspirations[1];
            }

            else if(_score >= 201 && _score <= 400)
            {
                pastLevel = _level;
                _level = levels[2];
                inspiration = inspirations[2];
            }

            else if(_score >= 401 && _score <= 600)
            {
                pastLevel = _level;
                _level = levels[3];
                inspiration = inspirations[3];
            }

            else if(_score >= 601 && _score <= 800)
            {
                pastLevel = _level;
                _level = levels[4];
                inspiration = inspirations[4];
            }

            else if(_score >= 801 && _score <= 1000)
            {
                pastLevel = _level;
                _level = levels[5];
                inspiration = inspirations[5];
            }

            else if(_score >= 1001 && _score <= 1200)
            {
                pastLevel = _level;
                _level = levels[6];
                inspiration = inspirations[6];
            }

            else if(_score >= 1201 && _score <= 1400)
            {
                pastLevel = _level;
                _level = levels[7];
                inspiration = inspirations[7];
            }

            else if(_score >= 1401 && _score <= 1600)
            {
                pastLevel = _level;
                _level = levels[8];
                inspiration = inspirations[8];
            }

            else if(_score >= 1601 && _score <= 1800)
            {
                pastLevel = _level;
                _level = levels[9];
                inspiration = inspirations[9];
            }

            else
            {
                pastLevel = _level;
                _level = levels[10];
                inspiration = inspirations[10];
            }
            
            Console.WriteLine("");
            Console.WriteLine($"{inspiration}");
            Console.WriteLine("");

            // [recordEventChoice - 1] will get the correct goal in the list
            _score +=  _goals[recordEventChoice - 1].RecordEvent();

            Console.WriteLine($"You now have a total of {_score} points.");
            Console.WriteLine("");

            if(pastLevel != _level)
            {
                Console.WriteLine($"    New Upgrade!\nNew Level: {_level}");
            }

            else
            {
                Console.WriteLine($"Current Level: {_level}");
            }
        }
    }

    // Saves the list of goals to a file.
    public void SaveGoals()
    {
        Console.WriteLine("");

        // prompt the user for a filename
        Console.Write("What is the filename to save your goals? ");
        _fileName = Console.ReadLine();

        // The file doesn't exist, so create one
        if(!File.Exists(_fileName))
        {
            Console.WriteLine("Creating journal file...");
            FileStream temp = File.Create(_fileName);
            temp.Close();
        }

        // The false parameter is to tell StreamWriter function to overwrite the existing file.
        using (StreamWriter outputFile = new StreamWriter(_fileName, false))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Saving your goals...");
    }

    // Loads the list of goals from a file.
    public void LoadGoals()
    {
        Console.WriteLine("");

        // prompt the user for a filename
        Console.Write("What is the filename to load your goals? ");
        _fileName = Console.ReadLine();

        Console.WriteLine("");
        // Check that file exists
        if(!File.Exists(_fileName))
        {
            Console.WriteLine("Sorry, that file can not be found. Please try again.");
        }

        else
        {
            using (StreamReader readFile = File.OpenText(_fileName))
            {
                string line;

                // To make sure there won't be duplicate entries in the _goals list.
            if(_goals.Count > 0)
                {
                    _goals.Clear();
                }

                FileInfo fileInfo = new FileInfo(_fileName);
                // Check that there is data in the file
                if (fileInfo.Exists && fileInfo.Length > 0)
                {
                    _score = int.Parse(readFile.ReadLine());
                    
                    while ((line = readFile.ReadLine()) != null)
                    {
                        string[] parts1 = line.Split(":");
                        string[] parts2 = parts1[1].Split("|");

                        if(parts1[0] == "SimpleGoal")
                        {
                            if(parts2[3] == "True")
                            {
                                _isComplete = true;
                            }

                            else
                            {
                                _isComplete = false;
                            }

                            _goals.Add(new SimpleGoal(parts2[0], parts2[1], parts2[2], _isComplete));
                        }

                        else if (parts1[0] == "EternalGoal")
                        {
                            _goals.Add(new EternalGoal(parts2[0], parts2[1], parts2[2]));
                        }

                        else if (parts1[0] == "ChecklistGoal")
                        {
                            int userAmountCompleted = int.Parse(parts2[3]);
                            _goals.Add(new ChecklistGoal(parts2[0], parts2[1], parts2[2], userAmountCompleted, parts2[4], parts2[5]));
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Loading your goals...");
                }

                else
                {
                    Console.WriteLine("You haven't created any goals yet.\nSelect option #1 on the Menu Options to start.");
                    Console.WriteLine("");
                }
            }
        }
    }
}