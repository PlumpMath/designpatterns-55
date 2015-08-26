using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract public class Produto
    {
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public string ObterInformacoes()
        {
            return Descricao + " Preço: R$" + string.Format("{0:0.00}", Preco);
        }
    }
}
