using Appliances.Models;

namespace Appliances.Services.Abstractions
{
    public interface ISocketService
    {
        public void Add(Appliance appliance);
        public void Disable(int index);
        public void Disable();
        public double GetTotalPower();
        public Appliance[] GetAll();
    }
}
