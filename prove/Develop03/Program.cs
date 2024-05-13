using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("Proverbs",3,5,8);

        // Console.WriteLine(reference.GetDisplayText());

        
        Reference reference = new Reference("1 Nephi",3,7);
        Scripture scripture = new Scripture(reference, "I will go and do what the Lord hath commanded");

        Console.WriteLine(scripture.GetDisplayText());

    }
}