using System;
using Microsoft.VisualBasic;

public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;
        

        public Activity()
        {
            _name = "";
            _description = "";
            _duration = 0;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            Console.Write("How long, in seconds, would you like for your session? ");
            string answer = Console.ReadLine();
            _duration = int.Parse(answer);
            
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well Done!!");
            ShowSpinner(5);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(5);
        }

        public void ShowSpinner(int seconds)
        {
            List<string> stringAnimation =
            [
                "|",
                "/",
                "-",
                "\\",
                "|",
                "/",
                "-",
                "\\",
            ];

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string s = stringAnimation[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i++;
                if (i >= stringAnimation.Count)
                {
                    i = 0;
                }
            }
            Console.Write(" ");
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i>0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }


    }