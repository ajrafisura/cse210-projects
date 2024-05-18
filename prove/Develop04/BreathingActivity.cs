using System;

    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing Activity";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
        }

        public void Run()
        {
            DisplayStartingMessage();
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            Console.Clear();
            Console.WriteLine("Get ready...");
        
            ShowSpinner(5);
            int i = 1;
            while (DateTime.Now < endTime)
            {
                if (i==1)
                {
                    Console.WriteLine();
                    Console.Write("Breathe in...");
                    ShowCountDown(2);
                    Console.WriteLine();
                    Console.Write("Now breathe out...");
                    ShowCountDown(3);
                    Console.WriteLine();
                    i++;
                }

                if (i>1)
                {
                    Console.WriteLine();
                    Console.Write("Breathe in...");
                    ShowCountDown(4);
                    Console.WriteLine();
                    Console.Write("Now breathe out...");
                    ShowCountDown(6);
                    Console.WriteLine();

                    i++;
                }
            }

            DisplayEndingMessage();
        }
    }