using System;

namespace Application.Dtos
{
    public class WeaterDto 
    {
        public DateTime Date { get; set; }
        public decimal TemperatureC { get; set; }
        public decimal TemperatureF { get; set; }
        public string Summary { get; set; }    
    }
}