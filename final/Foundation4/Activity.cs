using System;

    public abstract class Activity
    {
        protected string _date;
        protected double _minutes;

        public Activity(string date, double minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public virtual string GetActivitySummary()
        {
            return $"{_date} {GetType().ToString()} ({_minutes}) - Distance {Math.Round(GetDistance(),2)} km, Speed {Math.Round(GetSpeed(),2)} kph, Pace {Math.Round(GetPace(),2)} min per km";
        }
        public virtual double GetDistance()
        {
            return _minutes/GetPace();
        }

        public virtual double GetSpeed()
        {
            return GetDistance()/_minutes*60;
        }

        public virtual double GetPace()
        {
            return 60/GetSpeed();
        }
    }