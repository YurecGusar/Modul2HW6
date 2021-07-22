using Appliances.Enums;
using Appliances.Models;

namespace Appliances.Configs
{
    public class SettingConfig
    {
        public CurrencyData[] CurrencyData { get; set; }
        public Currency CurrentCurrency { get; set; }
    }
}
