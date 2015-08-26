using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication1;

namespace Strategy
{
    public class Factory : IExecutavel
    {
        public void Executar()
        {
            Program.Main();
        }
    }
}
