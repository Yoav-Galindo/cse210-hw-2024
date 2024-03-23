using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int breathingLogin = 0;
        int listingLoging = 0;
        
        while(userInput != "3")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing activity");
            // Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("2. Listing activity");
            Console.WriteLine("3. Quit");
            Console.WriteLine();
            Console.Write("Select an option: ");
            userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.BreathingPrompt();
                    breathingActivity.DisplayEndingMessage();

                    breathingLogin++;
                    break;

                case "2":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.PromptsListing();
                    listingActivity.DisplayEndingMessage();

                    listingLoging++;
                    break;
                    
                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Plese choose a number option. ");
                    break;

            }
        }
        Environment.Exit(0);
    }
}