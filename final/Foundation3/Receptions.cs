using System.Net.Sockets;

public class Receptions : Event
{
    private string _register;

    public Receptions(string title, string description, string date, string time, Address address, string register) : base(title, description, date, time, address)
    {
        _register = register;
    }

    public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {_register}";
        }

        public override string GetDescription()
        {
            return $"Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}";
        }
}