public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Reflect a moment when you felt immense gratitude",
        "Reflect an experience where you overcame a significant challenge",
        "Reflect on a time when you made a positive impact on someone's life",
        "Reflect a skill or talent you've been working to improve",
        "Reflectabout a place that holds special meaning to you and why",
        "Reflect a book, movie, or piece of art that deeply resonated with you",
        "Reflect a goal you've recently set for yourself and how you plan to achieve it",
        "Reflect a lesson you've learned from a past mistake or failure",
        "Reflect on a mentor or role model who has inspired you",
        "Reflect a moment of profound clarity or insight you've experienced recently",
    };

    public ListingActivity()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in your life vy having you lost as many things as you can in a certain area.");
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(0, _prompts.Count);
        return _prompts[i];
    }
    public void PromptsListing()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many ideas that come to your mind with the following prompt: ");
        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine("Starting in ...");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetTime();

        while(currentTime <= futureTime)
        {
            Console.Write("*");
            Console.ReadLine();
            currentTime = DateTime.Now;
        }
    }
}