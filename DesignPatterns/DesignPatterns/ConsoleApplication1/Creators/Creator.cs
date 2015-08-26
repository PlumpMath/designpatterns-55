using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Creators
{
    abstract public class Creator
    {

        #region Construtor
        public Creator()
        {
            this.CriarProdutos();
        }
        #endregion  

        #region Variáveis
        private List<Produto> _produtos = new List<Produto>();
        #endregion  

        #region Métodos
        public List<Produto> Produtos 
        {
            get { return _produtos; }
        }

        public abstract void CriarProdutos();

        #endregion

    }
}
