using Appliances.Enums;
using Appliances.Models;
using Appliances.Models.Appliances.ComputingDevices.Stations;
using Appliances.Models.Appliances.ComputingDevices.Stations.MultiMedias;
using Appliances.Models.Appliances.KitchenDevices.HeatDevices;
using Appliances.Models.Appliances.KitchenDevices.ShreddingDevices;
using Appliances.Services.Abstractions;

namespace Appliances.Providers
{
    public class ApplianceProvider
    {
        private readonly IConfigService _configService;
        private Appliance[] _data;
        public ApplianceProvider(
            IConfigService configService)
        {
            _configService = configService;
            _data = new Appliance[]
            {
                new Stove()
                {
                    Model = "A",
                    BurnersCount = 4,
                    Color = Color.Black,
                    MaxTemperature = 300,
                    Power = 5000,
                    Price = 8999,
                    Producer = Company.Braun
                },

                new Teapot()
                {
                    Model = "B",
                    Color = Color.Green,
                    MaxTemperature = 120,
                    Power = 700,
                    Noise = 20,
                    Price = 700,
                    Producer = Company.Electrolux,
                    Volume = 2.5,
                },
                new Blender()
                {
                    Model = "C",
                    BladesCount = 3,
                    Color = Color.White,
                    Noise = 45,
                    Type = BlenderType.Stationary,
                    Power = 200,
                    Price = 1399,
                    Producer = Company.Moulinex,
                },

                new MeatGrinder()
                {
                    Model = "D",
                    BladesCount = 5,
                    Color = Color.Grey,
                    Noise = 58,
                    NozzlesCount = 3,
                    Power = 340,
                    Price = 2300,
                    Producer = Company.Fujitsu,
                },

                new AudioSystem()
                {
                    Model = "E",
                    Color = Color.Yellow,
                    MaxFrequency = 1000,
                    MinFrequency = 150,
                    OS = OperatingSystem.Other,
                    ProcessorFrequency = 400,
                    Ports = new PortType[] { PortType.AUX, PortType.USB },
                    Power = 200,
                    PowerSupply = PowerSupply.Linear,
                    Price = 10000,
                    Producer = Company.JBL,
                },

                new Projector()
                {
                    Model = "F",
                    Color = Color.Grey,
                    ProcessorFrequency = 1000,
                    InstallationRange = 7,
                    OS = OperatingSystem.Linux,
                    Ports = new PortType[]
                    {
                        PortType.AUX,
                        PortType.DisplayPort,
                        PortType.HDMI,
                        PortType.USB,
                        PortType.LAN,
                    },
                    Power = 80,
                    PowerSupply = PowerSupply.Impulse,
                    Price = 6700,
                    Producer = Company.Xiaomi,
                },

                new PersonalComputer()
                {
                    Model = "XYZ",
                    Color = Color.White,
                    ProcessorFrequency = 3900,
                    IsMonoBlock = false,
                    OS = OperatingSystem.Windows,
                    Power = 800,
                    PowerSupply = PowerSupply.Linear,
                    Price = 19999,
                    Producer = Company.Asus,
                },

                new PersonalComputer()
                {
                    Model = "MAC",
                    Color = Color.White,
                    ProcessorFrequency = 2700,
                    IsMonoBlock = true,
                    OS = OperatingSystem.MacOs,
                    Power = 500,
                    PowerSupply = PowerSupply.Linear,
                    Price = 40000,
                    Producer = Company.Apple,
                },
            };
            GetAppliances = _data;
            GetCurrency(GetAppliances);
        }

        public Appliance[] GetAppliances { get; set; }

        private void GetCurrency(Appliance[] appliances)
        {
            foreach (var item in appliances)
            {
                item.Currency = _configService.SettingConfig.CurrentCurrency;
            }
        }
    }
}
