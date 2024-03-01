using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("**************** WECOME TO THE MAGIC NUMBER GAME ****************");
        Console.WriteLine();
        Console.WriteLine("Guess a Number Between 1 - 100:");
        Console.WriteLine();
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int iMagicNumber = int.Parse(magicNumber);

        Random numberGenerator = new Random();
        int iMagicNumber = numberGenerator.Next(1, 101);

        int iGuessNumber = -1;
        while (iMagicNumber != iGuessNumber)
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            iGuessNumber = int.Parse(guessNumber);

            if (iMagicNumber == iGuessNumber)
            {
                Console.WriteLine();
                Console.WriteLine("*** YOU GOT IT!!! ***");
            }
            else if(iMagicNumber < iGuessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }
    }
}