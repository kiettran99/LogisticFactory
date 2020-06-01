using LogisticFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticFactory.Factory
{
    public class TransportFactory
    {
        public static ITransport RequestTransport(string nameTransport)
        {
            switch (nameTransport)
            {
                case "Truck":
                    return new Truck();
                case "Ship":
                    return new Ship();
                default:
                    return null;
            }
        }
    }
}
