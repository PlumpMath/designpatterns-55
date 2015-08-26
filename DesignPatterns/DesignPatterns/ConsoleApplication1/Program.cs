using ConsoleApplication1.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {
            Creator[] listaProdutos = new Creator[2];
            listaProdutos[0] = new Comidas();
            listaProdutos[1] = new Bebidas();

            Console.WriteLine("\nMenu---------");
            foreach (Creator lista in listaProdutos)
            {

                Console.WriteLine("\n" + lista.GetType().Name + "--");

                foreach (Produto produto in lista.Produtos)
                {

                    Console.WriteLine(" " + produto.ObterInformacoes());

                }

            }
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }
    }
}
