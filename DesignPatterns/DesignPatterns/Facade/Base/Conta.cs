using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Base
{
    public class Conta
    {
        public Conta()
        {
            this.Saldo = 2000;
        }
        public double Saldo { get; set; }
    }
}
