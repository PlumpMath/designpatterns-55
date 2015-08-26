using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injeção_de_Dependência
{
    public class SqlServer : IBaseDeDados
    {
        public void AbrirConexao()
        {
            Console.WriteLine("Abrindo Conexão SQL Server");
        }

        public void FecharConexao()
        {
            Console.WriteLine("Fechando Conexão SQL Server");
        }

        public void ExecutarQuery(string query)
        {
            Console.WriteLine("Executando Query SQL Server");
        }
    }
}
