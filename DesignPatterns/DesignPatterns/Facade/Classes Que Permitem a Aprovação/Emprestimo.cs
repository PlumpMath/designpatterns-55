using Facade.Regras_de_Aprovação;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes_de_Aprovação
{
    public class Emprestimo
    {
        public bool temEmprestimos(Cliente c)
        {
            Console.WriteLine("Checando empréstimos de: " + c.Nome);
            return true;
        }
    }
}
