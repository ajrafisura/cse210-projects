using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Aries", "World War II");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Roberto Rodriguez","Fraction","7.3","8-19" );
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("Mary Waters","European History","The Cause of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());

    }
}