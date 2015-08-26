using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injeção_de_Dependência
{
    public class Oracle : IBaseDeDados
    {
        public void AbrirConexao()
        {
            Console.WriteLine("Abrindo Conexão Oracle");
        }

        public void FecharConexao()
        {
            Console.WriteLine("Fechando Conexão Oracle");
        }

        public void ExecutarQuery(string query)
        {
            Console.WriteLine("Fechando Conexão Oracle");
        }
    }
}
