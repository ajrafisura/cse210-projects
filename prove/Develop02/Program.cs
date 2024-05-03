using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Progam!");
        int answer = 0;
        Journal theJournal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput1 = Console.ReadLine();
            answer = int.Parse(userInput1);

            if (answer == 1)
            {
            Entry newEntry = new Entry();
            PromptGenerator newPrompt = new PromptGenerator();
            DateTime dateTime = DateTime.Now;
            newEntry._promptText = newPrompt.GetRandomPrompt();

            Console.WriteLine(newEntry._promptText);
            Console.Write("> ");
            string userInput2 = Console.ReadLine();
            newEntry._entryText = userInput2;
            newEntry._date = dateTime.ToShortDateString();
            theJournal.AddEntry(newEntry);
            }

            if (answer == 2)
            {
                theJournal.DisplayAll();

            }

            if (answer == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();

                theJournal.LoadFromFile(file);
            }

            if (answer == 4)
            {
                Console.WriteLine("What is the file name? ");
                string file = Console.ReadLine();
                
                theJournal.SaveToFile(file);
            }

            if (answer != 1 && answer != 2 && answer !=3 && answer !=4 && answer !=5)
            {
                Console.WriteLine("Please enter a valid answer (1-5).");
            }

        } while (answer != 5);
    }
}