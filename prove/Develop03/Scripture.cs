public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new Reference(bookName, chapter, verse);

        string[] split = text.Split(" ");
        foreach(string word in split)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index;
        do
        {
            index = random.Next(_words.Count);
        }
        while(_words[index].isHidden());
        _words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.isHidden())
                return false;
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine($"{_reference}:");
        foreach(Word word in _words)
        {
            if(word.isHidden())
            {
                Console.Write(new string('_', word.GetText().Length)+ " ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
        }
    }

}