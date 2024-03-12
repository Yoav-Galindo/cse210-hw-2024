public class PromptGenerator
{
    public static string[] _severalPrompts = 
    {
        "What is one thing you change in your day?",
        "What problem is not let you enjoy this week?",
        "what is one goal you reached this week or day?",
        "What did you eat today and why it was memorable food?",
        "Describe a peaceful moment during your day?",
        "What are you doing to change your present to get a better future?",
        "What was the last day you say I love you to my family?"
    };
    public List<string> _prompts = new List<string>(_severalPrompts);

    public PromptGenerator()
    {

    }

    public string GetRandomPrompt()
    {
        var randomPrompt = new Random();
        int indexNumber = randomPrompt.Next(_prompts.Count);
        string promptResult = _prompts[indexNumber];

        return promptResult;
    }

    public void Display()
    {
        
    }


}