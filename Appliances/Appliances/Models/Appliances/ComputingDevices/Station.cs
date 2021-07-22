using Appliances.Enums;
namespace Appliances.Models.Appliances.ComputingDevices
{
   public abstract class Station : ComputingDevice
    {
        public PowerSupply PowerSupply { get; set; }
    }
}
