using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Roberto Galindo", "Programming");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Lorely Hernandez", "Fractions", "7.3", "3-10, 20-21");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Carlos Antonio", "European History", "The Causes of World War");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

    }
}