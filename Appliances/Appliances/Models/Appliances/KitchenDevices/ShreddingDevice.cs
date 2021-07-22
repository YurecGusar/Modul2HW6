using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models.Appliances.KitchenDevices
{
    public abstract class ShreddingDevice : KitchenDevice
    {
        public int BladesCount { get; set; }
    }
}
