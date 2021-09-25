using System;

namespace App1.Models
{
    public class Item
    {
        public string Id { get; set; }
        public double Temperature { get; set; }
        public double Flowrate { get; set; } 
        public void Setvalues(int Temperature, int Flowrate)
        {
                Id = Guid.NewGuid().ToString();
                this.Temperature = Temperature;
                this.Flowrate = Flowrate;
        }
    }
}