using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injeção_de_Dependência.Bases_de_Dados
{
    public class Mock : IBaseDeDados
    {

        public void AbrirConexao()
        {
            Console.WriteLine("Abrindo Conexão Mock");
        }

        public void FecharConexao()
        {
            Console.WriteLine("Fechando Conexão Mock");
        }

        public void ExecutarQuery(string query)
        {
            Console.WriteLine("Executando Query Mock");
        }
    }
}
