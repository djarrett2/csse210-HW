public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
        {
            _weather = weatherForecast;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weather}";
        }

        public override string GetDescription()
        {
            return $"Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()}";
        }
}