namespace TP_FormationGit
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC => TemperatureF * Int32.MaxValue;

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public bool IsTrustable => true;
        public DateTime UpdateDate { get; set; }
    }
}