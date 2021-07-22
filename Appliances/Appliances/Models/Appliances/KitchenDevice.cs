using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models.Appliances
{
    public abstract class KitchenDevice : Appliance
    {
        public virtual double Noise { get; set; }
    }
}
