using System.Dynamic;

public class Journal
{
    public List<Entry> _Entries;

    public int NewEntry()
    {
        Entry entry = new Entry();
        entry.SetPrompt();

        Console.WriteLine($"\n{entry._prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entry.AddResponse(response);

        _Entries.Add(entry);

        Console.WriteLine("Entry recorded!\n");
        return 0;
    }
    public int Display()
    {
        foreach (Entry Entry in _Entries)
        {
            Entry.Display();
            Console.WriteLine();
        }
        return 0;
    }

public void Load()
    {
       
    }
    public int Save()
    {
        Console.WriteLine("Input Username: ");
        string input;
        input = Console.ReadLine();
        string filename = input;

        foreach (Entry Entry in _Entries)
        {
            string text = Entry.ToString();

            File.AppendAllText(filename, text);
        }

        return 0;
    }
}