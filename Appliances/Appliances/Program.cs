using System.Collections;
using Appliances.Extension;
using Appliances.Helpers;
using Appliances.Providers;
using Appliances.Services;
using Appliances.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Appliances
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Starter>()
                .AddSingleton<ISocketService, SocketService>()
                .AddTransient<ApplianceProvider>()
                .AddTransient<IComparer, ApplianceComparer>()
                .AddTransient<IConfigService, ConfigService>()
                .AddTransient<IApplianceService, ApplianceService>()
                .BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
