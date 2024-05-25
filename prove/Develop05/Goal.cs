using System;
using System.Runtime;

public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public abstract int RecordEvent();

        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {
            string checkbox = "";
            if (IsComplete() == true)
            {
                checkbox = "[X]";
            }
            else
            {
                checkbox = "[ ]";
            }

            return $"{checkbox} {_shortName} ({_description})";
        }

        public abstract string GetStringRepresentation();

        public void DisplayGoalName()
        {
            Console.Write($"{_shortName}.");
        }

    }