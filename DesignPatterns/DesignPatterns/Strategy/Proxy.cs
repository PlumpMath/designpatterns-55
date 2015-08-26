using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Proxy;

namespace Strategy
{
    public class Proxy : IExecutavel
    {
        public void Executar()
        {
            Program.Main();
        }
    }
}
