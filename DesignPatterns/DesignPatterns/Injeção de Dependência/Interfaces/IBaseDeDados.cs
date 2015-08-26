using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injeção_de_Dependência
{
    public interface IBaseDeDados
    {
        void AbrirConexao();
        void FecharConexao();
        void ExecutarQuery(string query);
    }
}
