using System;

    public class Biking : Activity
    {
        private double _speed;

        public Biking(string date, double minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
        }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}