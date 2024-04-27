using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your course grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter;
        string sign;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >=80)
        {
            letter = "B";
        }
        else if (grade>=70)
        {
            letter = "C";
        }
        else if (grade>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade%10 >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (grade%10 < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine ($"Your grade is: {letter}{sign}.");
        
        if (grade>=70)
        {
            Console.WriteLine("Congratulations for your hard work, you passed the course!");
        }
        else
        {
            Console.WriteLine("We are sorry but you can try harder the next time.");
        }

    }
}