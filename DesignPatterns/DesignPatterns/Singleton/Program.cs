using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            if (s1 == s2)
                Console.WriteLine("Same instance");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu inicial...");
            Console.ReadKey();
        }
    }
}
