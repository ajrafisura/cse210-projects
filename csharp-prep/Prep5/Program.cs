using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DislayWelcome();
        string userName = PrompUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName,square);

    }

    static void DislayWelcome()
    {
            Console.WriteLine("Welcome to the program!");
    }

    static string PrompUserName()
    {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
    }

    static int PromptUserNumber()
    {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
    }

    static int SquareNumber (int userNumber)
    {
            int square = userNumber * userNumber;
            return square;
    }

    static void DisplayResult (string userName, int square)
    {
            Console.WriteLine ($"{userName}, the square of your number is {square}");
    }
        
}