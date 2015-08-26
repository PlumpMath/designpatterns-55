using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Iniciar
    {
        static void Main()
        {
            string selecao = string.Empty;
            Menu menu = new Menu();
            while(selecao != "-1")
            {
                menu.ImprimirMenu();
                selecao = Console.ReadLine();

                menu.ExecutarMenuSelecionado(int.Parse(selecao));
            }
        }
    }
}
