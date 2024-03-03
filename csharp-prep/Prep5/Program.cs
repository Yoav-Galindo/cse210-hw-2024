using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMsg();
        string uName = NameImput();
        int uNumber = NumberImput();
        int sNumber = ComputeSquare(uNumber);
        NameAndSquare(uName, sNumber);

        
    }
    static void WelcomeMsg()
    {
        Console.WriteLine("*** Welcome to the program! ***");
    }
    static string NameImput()
    {
        Console.Write("Please enter your name: ");
        string sName = Console.ReadLine();
        return sName;
    }
    static int NumberImput()
    {
        Console.Write("Please enter your favorite number: ");
        string sNumber = Console.ReadLine();
        int iNumber = int.Parse(sNumber);
        return iNumber;
    }
    static int ComputeSquare(int iNumber)
    {
        int square = iNumber * iNumber;
        return square;
    }
    static void NameAndSquare(string sName, int square)
    {
        Console.WriteLine($"*** {sName}, the square of your number is {square} ***");
    }

}