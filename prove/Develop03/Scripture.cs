using System.Xml.XPath;

public class Scripture
{
    private List<Word> _scripture;
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _scripture = words;
    }

    public string DisplayScripture()
    {
        string text = _reference.DisplayReferenceString() + " ";
        foreach (Word w in _scripture)
        {
            text += w.DisplayWord() + " ";
        }
        return text;
    }
    public void HideWords(int numberToHide)
    {
        List<Word> visible = new List<Word>();

        foreach (Word w in _scripture)
        {
            if (!w.Hidden())
            {
                visible.Add(w);
            }
        }

        if (visible.Count == 0)
        {
            return;
        }
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = _random.Next(visible.Count);
            visible[randomIndex].Hide();
            visible.RemoveAt(randomIndex);
        }
    }

    public bool AllHidden()
    {
        foreach (Word w in _scripture)
        {
            if (!w.Hidden())
            {
                return false;
            }
        }
        return true;
    }
}