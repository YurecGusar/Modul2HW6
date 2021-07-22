using System.IO;
using Appliances.Configs;
using Appliances.Enums;
using Appliances.Models;
using Appliances.Services.Abstractions;
using Newtonsoft.Json;

namespace Appliances.Services
{
    public class ConfigService : IConfigService
    {
        private const string _jsonFileName = "config.json";

        public ConfigService()
        {
            var config = GetConfig();
            SocketQuantity = config.SocketQuantity;
            SettingConfig = config.SettingConfig;
        }

        public int SocketQuantity { get; set; }
        public SettingConfig SettingConfig { get; set; }
        private Config GetConfig()
        {
            return new Config
            {
                SocketQuantity = 5,
                SettingConfig = new SettingConfig
                {
                    CurrencyData = new CurrencyData[]
                    {
                        new CurrencyData
                        {
                            Currency = Currency.USD,
                            RateDefaultToCurrency = 0.0367
                        },
                        new CurrencyData
                        {
                            Currency = Currency.UAH,
                            RateDefaultToCurrency = 1
                        }
                    },
                    CurrentCurrency = Currency.USD
                }
            };
        }

        private void Serialisation(Config config)
        {
            var newConfig = config;
            var json = JsonConvert.SerializeObject(newConfig);
            File.WriteAllText(_jsonFileName, json);
        }

        private Config DeSerialisation()
        {
            var readFile = File.ReadAllText(_jsonFileName);
            var config = JsonConvert.DeserializeObject<Config>(readFile);
            return config;
        }
    }
}
