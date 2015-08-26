using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Injeção_de_Dependência;

namespace Strategy
{
    public class DependencyInfection : IExecutavel
    {
        public void Executar()
        {
            Program.Main();
        }
    }
}
