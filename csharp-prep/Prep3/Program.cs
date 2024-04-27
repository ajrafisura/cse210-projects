using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);
            int guess = -1;
            int i = 0;
            do
            {
                Console.Write("What is your guess? ");
                string userInput1 = Console.ReadLine();
                guess = int.Parse(userInput1);
                i = i + 1;

                if (magicNumber == guess)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (magicNumber>guess)
                {
                    Console.WriteLine("Higher.");
                }
                else
                {
                    Console.WriteLine("Lower.");
                } 
            } while (magicNumber != guess);

            Console.WriteLine($"Number of attempts: {i}");
            Console.Write("Do you want to play again? (YES/NO)");
            answer = Console.ReadLine();
            
        } while (answer.ToLower() == "yes");
        
    }
}