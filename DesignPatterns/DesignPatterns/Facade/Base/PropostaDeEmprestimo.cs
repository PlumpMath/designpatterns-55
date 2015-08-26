using Facade.Classes_de_Aprovação;
using Facade.Regras_de_Aprovação;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Base
{
    public class PropostaDeEmprestimo
    {
        private Banco _banco = new Banco();

        private Emprestimo _emprestimo = new Emprestimo();

        private Credito _credito = new Credito();



        public bool PodeContratar(Cliente c, double valor)
        {
            Console.WriteLine("{0} tenta sacar {1:C} emprestado\n",c.Nome, valor);

            bool status = true;

            if (!_banco.TemSaldoNoBanco(c, valor))
            {
                Console.WriteLine(c.Nome + " não possui o saldo necessário para a operação.");
                status = false;

            }

            else if (!_emprestimo.temEmprestimos(c))
            {
                Console.WriteLine(c.Nome + "já possui empréstimos.");
                status = false;

            }

            else if (!_credito.temCredito(c))
            {
                Console.WriteLine(c.Nome + "não possui o crédito necessário para a operação.");
                status = false;

            }

            return status;

        }
    }
}
