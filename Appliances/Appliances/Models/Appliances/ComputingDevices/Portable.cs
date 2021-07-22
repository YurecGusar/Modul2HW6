using Appliances.Enums;

namespace Appliances.Models.Appliances.ComputingDevices
{
    public abstract class Portable : ComputingDevice
    {
        public double BateryCapacity { get; set; }
        public double Weight { get; set; }
        public PortablePowerSupply PortablePowerSupply { get; set; }
    }
}
