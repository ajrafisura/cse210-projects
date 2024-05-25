using System;

    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0;
        }

        public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = amountCompleted;
        }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted < _target)
        {
            return _points;  
        }
        else if(_amountCompleted == _target)
        {
            
            return _points + _bonus;
        }
        else
        {
            return 0;
        }
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
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

            return $"{checkbox} {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
    
}