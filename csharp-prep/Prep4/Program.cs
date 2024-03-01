using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List creation
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // while loop
        int iNumber = -1;
        while(iNumber != 0)
        {
            
            // User Imput
            Console.Write("Enter number: ");
            string sNumber = Console.ReadLine();
            iNumber = int.Parse(sNumber);
            // Conditional
            if(iNumber != 0)
            {
                numbers.Add(iNumber);
            }
        }
        int addingNumbers = 0;
        foreach (int number in numbers)
        {
            addingNumbers += number;
        }
        Console.WriteLine($"The sum is: {addingNumbers}");

        float average = ((float)addingNumbers) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}