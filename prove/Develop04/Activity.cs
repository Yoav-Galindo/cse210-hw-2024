public class Activity
{
    private string _activityName;
    private string _ActivityDescription;
    private int _duration;


    public Activity()
    {
        _activityName = "";
        _duration = 20;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _ActivityDescription = activityDescription; 
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"This is the {_activityName}.\n");
        Console.WriteLine(_ActivityDescription);
    }

    public void inputDuration()
    {
        Console.WriteLine("How many seconds you want for this session? ");
        string sDuration = Console.ReadLine();
        int iduration = int.Parse(sDuration);
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"AWESOME, WELL DONE!!!");
        ShowSpinner(5);
        Console.WriteLine($"You got {_duration} seconds of the {_activityName}.");
        ShowSpinner(5);
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        inputDuration();
        GetReady();
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        int spinnerSpot = 30;
        int spinWait = 600;

        spinnerSpot = Console.CursorLeft;
        DateTime futureTime = GetFutureTime(5);

        while(DateTime.Now < futureTime)
        {
            char[] spinTransition = new char[]{'|','*','-'};
            foreach (char spinChar in spinTransition)
            {
                Console.CursorLeft = spinnerSpot;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }
        Console.CursorLeft = spinnerSpot;
        Console.Write(" ");
    }
    public void ShowCountDown(int seconds)
    {
        int countDownSpot = 25;
        int countDownWait = 1000;
        countDownSpot = Console.CursorLeft;

        for(int i = 0; i <= seconds; i++)
        {
            Console.CursorLeft = countDownSpot;
            Console.Write(seconds - i);
            Thread.Sleep(countDownWait);
        }
        Console.CursorLeft = countDownSpot;
        Console.Write(" ");

    }
    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        
        return currentTime;
    }
}