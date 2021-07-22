using Appliances.Enums;

namespace Appliances.Models.Abstractions
{
    public interface ITouchscreen
    {
        public int TouchQyentity { get; set; }
        public MatrixType MatrixType { get; set; }
    }
}
