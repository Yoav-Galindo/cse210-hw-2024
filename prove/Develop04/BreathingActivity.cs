public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetActivityName("Breathing Activity");
        SetActivityDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focous on your breathing.");
    }
    public void BreathingPrompt()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetTime();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Start breathing in...");
        ShowCountDown(3);
        Console.WriteLine();
        Console.WriteLine("Starting breathing out in...");
        ShowCountDown(3);

            while(currentTime <= futureTime)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Start breathing in...");
        ShowCountDown(3);
        Console.WriteLine();
        Console.WriteLine("Starting breathing out in...");
        ShowCountDown(3);
        currentTime = DateTime.Now;
    }
    }

}