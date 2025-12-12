using System.Net.Sockets;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    
    public string GetStandardDetails()
        {
            return $"Event: {_title}\n" + $"Description: {_description}\n" + $"Date: {_date}\n" + $"Time: {_time}\n" + $"Address: {_address.GetFullAddress()}";
        }

        public virtual string GetFullDetails()
        {
            return GetStandardDetails();
        }

        public virtual string GetDescription()
        {
            return $"Event: {_title}\nDate: {_date}";
        }

        protected string GetTitle()
        {
            return _title;
        }

        protected string GetDate()
        {
            return _date;
        }
}