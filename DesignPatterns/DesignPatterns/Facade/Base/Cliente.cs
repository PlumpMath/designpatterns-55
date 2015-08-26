using Facade.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Regras_de_Aprovação
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            this.Nome = nome;
            this.ContaBancaria = new Conta();
        }

        public string Nome { get; set; }
        public Conta ContaBancaria { get; set; }
        
    }
}
