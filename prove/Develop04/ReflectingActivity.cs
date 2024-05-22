using System;
using System.ComponentModel;

public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>();
        private List<string> _questions = new List<string>();

        public ReflectingActivity()
        {
            _name = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }

        public void Run()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            DisplayPrompt();
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();
            do
            {
                Console.WriteLine();
                DisplayQuestion();
                ShowSpinner(15);
            } while (DateTime.Now < endTime);

            Console.WriteLine();
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            _prompts.Add("Think of a time when you stood up for someone else.");
            _prompts.Add("Think of a time when you did something really difficult.");
            _prompts.Add("Think of a time when you helped someone in need.");
            _prompts.Add("Think of a time when you did something truly selfless.");

            Random random = new Random();
            
            return _prompts[random.Next(_prompts.Count)];

        }
        public string GetRandomQuestion()
        {
            _questions.Add("Why was this experience meaningful to you?");
            _questions.Add("Have you ever done anything like this before?");
            _questions.Add("How did you get started?");
            _questions.Add("How did you feel when it was complete?");
            _questions.Add("What made this time different than other times when you were not as successful?");
            _questions.Add("What is your favorite thing about this experience?");
            _questions.Add("What could you learn from this experience that applies to other situations?");
            _questions.Add("What did you learn about yourself through this experience?");
            _questions.Add("How can you keep this experience in mind in the future?");

            Random random = new Random();

            return _questions[random.Next(_questions.Count)]; 
        }    

        public void DisplayPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
        }

        public void DisplayQuestion()
        {
            Console.Write($"> {GetRandomQuestion()} ");
        }
    }