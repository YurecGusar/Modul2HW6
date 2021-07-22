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
                .AddTransient<ISocketService, SocketService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();
            var starter = serviceProvider.GetService<Starter>();
            starter.Run();
        }
    }
}
