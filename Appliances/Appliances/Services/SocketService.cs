using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appliances.Services.Abstractions;
using Appliances.Models;

namespace Appliances.Services
{
    public class SocketService : ISocketService
    {
        private readonly int _socketQuantity;
        private int _counter;
        private Appliance[] _appliances;

        public SocketService()
        {
            _counter = 0;
            _socketQuantity = 5;
            _appliances = new Appliance[_socketQuantity];
        }

        public void Add(Appliance appliance)
        {
            _appliances[_counter] = appliance;
            _counter++;
        }

        public void Disable(int index)
        {
              _appliances[index] = null;
        }

        public void Disable()
        {
            _appliances = null;
        }

        public Appliance[] GetAll()
        {
            return _appliances;
        }
    }
}
