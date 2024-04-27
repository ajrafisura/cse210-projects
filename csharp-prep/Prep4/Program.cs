using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int sum = 0;
        float average;
        int smallestPositive = 9999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        foreach (int num in numbers)
            {
                if (num > 0)
                {
                    if (num < smallestPositive)
                    {
                        smallestPositive = num;
                    }
                   
                }
                sum += num;
            }

        int max = numbers.Max();
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum of the numbers is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {max}.");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}.");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}