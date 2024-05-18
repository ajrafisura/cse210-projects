using System;

    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts = new List<string>();

        public ListingActivity()
        {
            _name = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        }

        public void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine();
            Console.WriteLine("List as many responses you can to the following prompt: ");
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine("You may begin in:");
            ShowCountDown(5);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            _count = 0;
            do
            {
                Console.Write("> ");
                string answer = Console.ReadLine();
                _count++;
            }while (DateTime.Now < endTime);
            Console.WriteLine($"You listed {_count} items.");
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");

            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        public List<string> GetListFromUser()
        {
            List<string> prompt = new List<string>();
            return prompt;
        }
    }