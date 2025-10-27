public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }
    public bool Hidden()
    {
        return _hidden;
    }
    public string DisplayWord()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}