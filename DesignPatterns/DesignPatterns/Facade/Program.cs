using Facade.Base;
using Facade.Regras_de_Aprovação;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        public static void Main()
        {
            PropostaDeEmprestimo aprovacao = new PropostaDeEmprestimo();

            Cliente cliente = new Cliente("Cara legal");

            bool status = aprovacao.PodeContratar(cliente, 2500);

            Console.WriteLine("\nO empréstimo de " + cliente.Nome +

                " foi " + (status ? "Aprovado" : "Negado"));

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();

        }
    }
}
