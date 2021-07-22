using System.Text.Json.Serialization;
using Appliances.Enums;
using Appliances.Models;

namespace Appliances.Configs
{
    public class SettingConfig
    {
        [JsonPropertyName("currencyData")]
        public CurrencyData[] CurrencyData { get; set; }
        [JsonPropertyName("currentCurrency")]
        public Currency CurrentCurrency { get; set; }
    }
}
