using Appliances.Enums;
using Appliances.Models.Abstractions;

namespace Appliances.Models.Appliances.ComputingDevices.Portables.Laptops
{
    public class TouchLaptop : Notebook, ITouchscreen
    {
        public int TouchQyentity { get; set; }
        public MatrixType MatrixType { get; set; }
    }
}
