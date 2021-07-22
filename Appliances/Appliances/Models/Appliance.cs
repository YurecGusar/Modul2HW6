using Modul2HW6.Enums;

namespace Modul2HW6.Models
{
    public abstract class Appliance
    {
        public Company Producer { get; set; }
        public double Price { get; set; }
        public Color Color { get; set; }
        public double Power { get; set; }
    }
}
