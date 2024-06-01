using System;

    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;


        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        public string GetLectureDetails()
        {
            return $"Speaker: {_speaker} \nCapacity: {_capacity}";
        }
    }