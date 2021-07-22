using System;
using Appliances.Enums;
using Appliances.Models;
using Appliances.Providers;
using Appliances.Services.Abstractions;

namespace Appliances.Services
{
    public class ApplianceService : IApplianceService
    {
        private readonly ApplianceProvider _applianceProvider;
        private readonly IConfigService _config;
        public ApplianceService(
            IConfigService configService,
            ApplianceProvider applianceProvider)
        {
            _config = configService;
            _applianceProvider = applianceProvider;
            GetAllAppliance = GetAll();
        }

        public Appliance[] GetAllAppliance { get; set; }

        private Appliance[] GetAll()
        {
            var result = _applianceProvider.GetAppliances;
            ConvertCurrency(result);
            PriceConvert(result);
            return result;
        }

        private void ConvertCurrency(Appliance[] appliances)
        {
            foreach (var item in appliances)
            {
                var currency = GetCurrencyData(item.Currency);
                item.Price = item.Price * currency.RateDefaultToCurrency;
            }
        }

        private CurrencyData GetCurrencyData(Currency currency)
        {
            foreach (var item in _config.SettingConfig.CurrencyData)
            {
                if (item.Currency == currency)
                {
                    return item;
                }
            }

            return null;
        }

        private void PriceConvert(Appliance[] appliances)
        {
            foreach (var item in appliances)
            {
                item.Price = Math.Round(item.Price, 2);
            }
        }
    }
}
