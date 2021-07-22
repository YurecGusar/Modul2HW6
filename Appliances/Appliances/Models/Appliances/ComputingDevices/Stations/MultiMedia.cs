using Appliances.Enums;

namespace Appliances.Models.Appliances.ComputingDevices.Stations
{
   public abstract class MultiMedia : Station
    {
        public PortType[] Ports { get; set; }
    }
}
