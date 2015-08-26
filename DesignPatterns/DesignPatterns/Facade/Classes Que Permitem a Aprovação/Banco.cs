using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Regras_de_Aprovação
{
    public class Banco
    {
        public bool TemSaldoNoBanco(Cliente c, double saldoInformado)
        {
            Console.WriteLine("Checando saldo para: " + c.Nome);
            return c.ContaBancaria.Saldo>=saldoInformado;
        }

    }
}
