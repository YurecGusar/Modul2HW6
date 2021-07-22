using System;
using System.Collections;
using Appliances.Providers;
using Appliances.Services.Abstractions;
using Appliances.Extension;
using Appliances.Exceptions;
using Appliances.Enums;
using Appliances.Models;

namespace Appliances
{
    public class Starter
    {
        private readonly IApplianceService _appliance;
        private readonly ISocketService _socketService;
        private readonly IComparer _comparer;
        private readonly IConfigService _config;

        public Starter(
            ISocketService socketService,
            IApplianceService appliance,
            IComparer comparer,
            IConfigService config)
        {
            _socketService = socketService;
            _appliance = appliance;
            _comparer = comparer;
            _config = config;
        }

        public void Run()
        {
            var model = "F";
            var allAppliance = _appliance.GetAllAppliance;

            for (var i = 0; i < _config.SocketQuantity; i++)
            {
            _socketService.Add(allAppliance[i]);
            }

            Array.Sort(allAppliance, _comparer);
            var applianceByModel = allAppliance.GetByModel(model);
            Console.WriteLine($"{applianceByModel.Model} {applianceByModel.Price} {applianceByModel.Currency}");
            Console.WriteLine();
            var applianceByColor = allAppliance.GetAllWithColor(Color.White);
            foreach (var item in applianceByColor)
            {
                Console.WriteLine($"{GetNameOfAppliance(item.GetType())} {item.Model} {item.Price} {item.Currency}");
            }

            var applianceInSocket = _socketService.GetAll();
            var totalPower = applianceInSocket.GetTotalPower();
            Console.WriteLine();
            Console.WriteLine($"{nameof(applianceInSocket)} {nameof(totalPower)}: {totalPower}");
        }

        private string GetNameOfAppliance(object str)
        {
            var newStr = str.ToString().Split('.');
            return newStr[newStr.Length - 1];
        }
    }
}
