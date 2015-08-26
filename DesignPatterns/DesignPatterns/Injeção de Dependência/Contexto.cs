using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injeção_de_Dependência.Bases_de_Dados
{
    public class Contexto
    {
        public Contexto()
        {
            this._banco = new Oracle();
        }

        private IBaseDeDados _banco;

        public void SalvarRegistro(string registro) 
        {
            _banco.AbrirConexao();
            _banco.ExecutarQuery(registro);
            _banco.FecharConexao();
        }
    }
}
