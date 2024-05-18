using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        do
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity.");
            Console.WriteLine(" 2. Start reflecting activity.");
            Console.WriteLine(" 3. Start listing activity.");
            Console.WriteLine(" 4. Quit.");
            Console.Write("Select the choice from the menu: ");
            answer = Console.ReadLine();
        

            if (answer == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if (answer == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }

            else if (answer == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

            else if (answer == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Thank You. Goodbye.");
            }

            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }

        } while (answer != "4");
    }
}