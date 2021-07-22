using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances.Exceptions
{
    public class FiendException : Exception
    {
        public FiendException(string message)
               : base(message)
        {
        }
    }
}
