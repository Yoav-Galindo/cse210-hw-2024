public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string bookName, int chapter, int verse)
    {
        this._book = bookName;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = verse;
    }

    public Reference(string bookName, int chapter, int verse, int endVerse)
    {
        this._book = bookName;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }

    public override string ToString()
    {
        if(_verse == _endVerse)
        {
            return $"{_book} {_chapter}; {_verse} - {_endVerse}";
        }
            
        else
        {
            return $"{_book} {_chapter}: {_verse} - {_endVerse}";
        }
            
        
    }
}