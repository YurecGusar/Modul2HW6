using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances.Models.Appliances.ComputingDevices
{
   public abstract class Portable : ComputingDevice
    {
        public double BateryCapacity { get; set; }
    }
}
