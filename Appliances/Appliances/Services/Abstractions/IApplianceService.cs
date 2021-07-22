using Appliances.Models;

namespace Appliances.Services.Abstractions
{
    public interface IApplianceService
    {
        public Appliance[] GetAllAppliance { get; set; }
    }
}
