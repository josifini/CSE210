using System;

public class OutdoorGathering : Event
{
    public string WeatherForecast { get; private set; }

    public OutdoorGathering(string title, string description, DateTime date, string time, Address eventAddress, string weatherForecast)
        : base(title, description, date, time, eventAddress)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}, Weather Forecast: {WeatherForecast}";
    }
}
