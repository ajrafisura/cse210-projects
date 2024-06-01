using System;

    public class Event
    {
        protected string _title;
        protected string _description;
        protected string _date;
        protected string _time;
        protected Address _address;

        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }


        public string GetStandardDetails()
        {
            return $"{_title} - {_description} \n{_date} @ {_time} \n{_address.GetAddress()}";
        }

        public string GetEventType()
        {
            string type;
            if (GetType().ToString() == "Lecture")
            {
                type = "Lecture";
            }
            else if (GetType().ToString() == "Reception")
            {
                type = "Reception";
            }
            else
            {
                type = "Outdoor";
            }
            return type;
        }
        public string GetFullDetails()
        {          
            return $"\nType: {GetEventType()} \n{GetStandardDetails()}";
        }

        public string GetShortDescription()
        {
            return $"\n{GetEventType()} - {_title} - {_date}\n====================================================================\n";
        }
    }