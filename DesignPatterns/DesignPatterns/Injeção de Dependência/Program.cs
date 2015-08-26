using Injeção_de_Dependência.Bases_de_Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injeção_de_Dependência
{
    public class Program
    {
        public static void Main()
        {
            var _contexto = new Contexto();

            _contexto.SalvarRegistro("Legal");

            Console.ReadKey();
        }
    }
}
