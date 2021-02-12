using System;
using Domain.CustomEntities;

namespace Domain.Entities
{
    public class Weater : BaseEntity
    {
        public DateTime Date { get; set; }
        public decimal TemperatureC { get; set; }
        public decimal TemperatureF { get; set; }
        public string Summary { get; set; }    
    }
}