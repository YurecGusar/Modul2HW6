using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models.Appliances.KitchenDevices.HeatDevices
{
    public class Stove : HeatDevice
    {
        public override double Noise { get => 0; }
        public int BurnersCount { get; set; }
    }
}
