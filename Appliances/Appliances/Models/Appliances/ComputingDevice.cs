using Appliances.Enums;

namespace Appliances.Models.Appliances
{
   public abstract class ComputingDevice : Appliance
    {
        public double ProcessorFrequency { get; set; }
        public OperatingSystem OS { get; set; }
    }
}
