using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyCalculadora : ICalculadora
    {
        private Calculadora _calculadora = new Calculadora();


        public double Add(double x, double y)
        {
            x *= 2;
            return _calculadora.Add(x,y);
        }
    }
}
