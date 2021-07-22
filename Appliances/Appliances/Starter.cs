using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appliances.Services.Abstractions;
using Appliances.Providers;

namespace Appliances
{
    public class Starter
    {
        private readonly ApplianceProvider _applianceProvider;
        private readonly ISocketService _socketService;

        public Starter(
            ISocketService socketService,
            ApplianceProvider appliance)
        {
            _socketService = socketService;
            _applianceProvider = appliance;
        }

        public void Run()
        {
            var app = _applianceProvider.GetAppliances;
            _socketService.Add(app[0]);
            _socketService.Add(app[1]);
            /*_socketService.Disable(0);*/
            app = _socketService.GetAll();
            Console.WriteLine(_socketService.GetTotalPower());
        }
    }
}
