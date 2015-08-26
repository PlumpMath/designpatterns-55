using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calculando Soma de 1+2: ");
            var calc = new Calculadora();
            var calcp = new ProxyCalculadora();
            Console.WriteLine(calc.Add(1,2));
            Console.WriteLine("Somando 1+2 pelo proxy (Dobra primeiro numero): ");
            Console.WriteLine(calcp.Add(1,2));
            Console.WriteLine("\nPressine qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }
    }
}
