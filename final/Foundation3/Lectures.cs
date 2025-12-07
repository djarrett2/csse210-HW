public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity) : base(title, description, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}