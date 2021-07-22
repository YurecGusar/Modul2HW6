using System;
using System.Collections;
using Appliances.Providers;
using Appliances.Services.Abstractions;
using Appliances.Extension;
using Appliances.Exceptions;
using Appliances.Enums;

namespace Appliances
{
    public class Starter
    {
        private readonly ApplianceProvider _applianceProvider;
        private readonly ISocketService _socketService;
        private readonly IComparer _comparer;

        public Starter(
            ISocketService socketService,
            ApplianceProvider appliance,
            IComparer comparer)
        {
            _socketService = socketService;
            _applianceProvider = appliance;
            _comparer = comparer;
        }

        public void Run()
        {
            var model = "F";
            var app = _applianceProvider.GetAppliances;

            _socketService.Add(app[0]);
            _socketService.Add(app[1]);
            _socketService.Add(app[2]);

            /*_socketService.Disable(0);*/
            /*app = _socketService.GetAll();*/

            Array.Sort(app, _comparer);
            try
            {
                var a = app.GetByModel(model);
                Console.WriteLine(a.Price);
                var b = app.GetAllWithColor(Color.White);
                foreach (var item in b)
                {
                    Console.WriteLine(item.Model);
                }
            }
            catch (FiendException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
