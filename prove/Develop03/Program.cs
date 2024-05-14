using System;
using System.Globalization;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("Proverbs",3,5,8);

        // Console.WriteLine(reference.GetDisplayText());

        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Reference reference = new Reference("1 Nephi",3,7);
        Scripture scripture = new Scripture(reference, text);

        
        string answer = "yes";
        do
        {
            Console.Clear();
            Console.WriteLine (scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            answer = Console.ReadLine();
            if (scripture.IsCompletelyHidden() != true)
            {
            scripture.HideRandomWords(3);
            }
            else
            {
                break;
            }
            

        }while (answer != "quit");

    }
}