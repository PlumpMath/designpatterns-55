using ConsoleApplication1.Produtos.Bebidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Creators
{
    public class Bebidas : Creator
    {
        public override void CriarProdutos()
        {
            Produtos.Add(new Vinho());
            Produtos.Add(new Cerveja());
        }
    }
}
