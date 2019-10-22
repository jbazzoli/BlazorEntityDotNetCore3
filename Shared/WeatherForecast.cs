using System;
using System.ComponentModel.DataAnnotations;

namespace ModelShared
{
    public class WeatherForecast
    {
        [Key]
        public int WeatherID { get; set; }
    
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        [Required]
        public string Summary { get; set; }
    }
}
