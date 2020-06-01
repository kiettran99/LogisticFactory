using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticFactory.Models
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Driver by land box";
        }
    }
}
