using Appliances.Enums;
using Appliances.Models.Abstractions;

namespace Appliances.Models.Appliances.ComputingDevices.Portables.Smartphones
{
    public class TouchscreenPhone : Smartphone, ITouchscreen
    {
        public int TouchQyentity { get; set; }
        public MatrixType MatrixType { get; set; }
    }
}
