using Facade.Regras_de_Aprovação;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes_de_Aprovação
{
    public class Credito
    {
        public bool temCredito(Cliente c)
        {
            Console.WriteLine("Checando crédito de: " + c.Nome);
            return true;
        }
    }
}
