using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticFactory.Models
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Deliver by sea in a container";
        }
    }
}
