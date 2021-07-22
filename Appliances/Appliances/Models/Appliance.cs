using Appliances.Enums;

namespace Appliances.Models
{
    public abstract class Appliance
    {
        public string Model { get; set; }
        public Company Producer { get; set; }
        public double Price { get; set; }
        public Color Color { get; set; }
        public double Power { get; set; }
    }
}
