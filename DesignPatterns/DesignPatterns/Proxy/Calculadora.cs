using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Calculadora : ICalculadora
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
