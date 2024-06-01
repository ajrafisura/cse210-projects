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
            return (((double)_laps*50)/1000);
        }

}