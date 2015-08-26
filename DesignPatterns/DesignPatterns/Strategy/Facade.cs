using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade;


namespace Strategy
{
    public class Facade : IExecutavel
    {

        public void Executar()
        {
            Program.Main();
        }
    }
}
