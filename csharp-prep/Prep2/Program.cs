using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string sPercentage = Console.ReadLine();
        int iPercentage = int.Parse(sPercentage);

        string letter = "";
        
        if(iPercentage >= 90)
        {
            letter = "A";
        }

        else if (iPercentage >= 80)
        {
            letter = "B";
        }
        else if (iPercentage >= 70)
        {
            letter = "C";
        }
        else if (iPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got the grade {letter}");
        
        Console.WriteLine();
        if(iPercentage >= 70)
        {
            Console.WriteLine("You passed the class, congratulations!!!");
        }
        else
        {
            Console.WriteLine("You fail the class, good luck next time.");
        }
    }
}