using System;

    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, double minutes, int laps) : base(date,minutes)
        {
            _laps = laps;
        }

    public override double GetDistance()
    {
        double distance = (((double)_laps*50)/1000);
        return distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance()/_minutes)*60;
    }

    public override double GetPace()
    {
        return 60/(GetSpeed());
    }
}