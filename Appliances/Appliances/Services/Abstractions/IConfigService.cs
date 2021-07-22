using Appliances.Configs;

namespace Appliances.Services.Abstractions
{
    public interface IConfigService
    {
        public int SocketQuantity { get; set; }
        public SettingConfig SettingConfig { get; set; }
    }
}
