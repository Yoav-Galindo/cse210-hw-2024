using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture ("John ", 13, 16, "Verily, verily, I say unto you, The servant is not greater than his lord; neither he that is sent greater than he that sent him. \n");
        

        while(true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();
            if(userInput.ToLower() == "quit") 
                break;
            if(scripture.AllWordsHidden())
                break;

            for(int i = 0; i < 3; i++)
            {
                scripture.HideRandomWord();
                if(scripture.AllWordsHidden())
                    break;
            }
        }

    }
}