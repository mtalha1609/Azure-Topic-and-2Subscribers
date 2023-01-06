namespace Azurebussubscription
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    //WOrking starts from here

    public class WeatherForecastAdded
    {
        public Guid Id { get; set; }

        public DateTime DateTime { get; set; }

         public DateTime CreatedDateTime { get; set; }

    }
}