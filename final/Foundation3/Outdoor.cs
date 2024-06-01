using System;

    public class Outdoor : Event
    {
        private string _weather;

        public Outdoor(string name, string description, string date, string time, Address address, string weather) : base(name, description, date, time, address)
        {
            _weather = weather;
        }

        public string GetOutdoorDetails()
        {
            return $"Weather: {_weather}";
        }
    }