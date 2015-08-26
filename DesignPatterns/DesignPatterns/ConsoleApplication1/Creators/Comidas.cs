using ConsoleApplication1.Produtos.Comidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Creators
{
    public class Comidas : Creator
    {
        public override void CriarProdutos()
        {
            Produtos.Add(new Pizza());
            Produtos.Add(new Sushi());
        }
    }
}
