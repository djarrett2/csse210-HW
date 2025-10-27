using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;

public class Entry
{


    public string _prompt;
    public string _response;
    public string _date;
    private Random _random = new Random();
    
    public Entry ()
    {
        SetPrompt();
    }
    public Entry (string date)
    {
        _date = date;
        SetPrompt();
        _response = "......Empty......";

    }
    
    public List<string> _Prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most delicious thing I ate today?",
        "What stuck out in my day",
        "What did I learn today?",
        "How did I grow myself today?"
    };

    Random random = new Random();

    public int SetPrompt()
    {
        int randomPrompt = random.Next(_Prompts.Count);
        _prompt = _Prompts[randomPrompt];
        return 0;
    }

    public int AddDate(string date)
    {
        _date = date;
        return 0;
    }

    public int AddResponse(string input)
    {
        _response = input;
        return 0;
    }

    public int Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        Console.WriteLine();

        Console.WriteLine(_response);

        return 0;
    }

    public string GetDate()
    {
        return _date;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public string GetResponse()
    {
        return _response;
    }

    public override string ToString()
    {
        return $"Date: {_date}, Prompt: {_prompt}, Response: {_response}";
        
    }
}