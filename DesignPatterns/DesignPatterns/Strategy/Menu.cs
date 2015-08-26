using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Menu
    {
        private List<ItemDoMenu> _menu;

        public Menu()
        {
            _menu = new List<ItemDoMenu>();
            _menu.Add(new ItemDoMenu(1, "Factory Method", new Factory()));
            _menu.Add(new ItemDoMenu(2, "Facade", new Facade()));
            _menu.Add(new ItemDoMenu(3, "Dependency Injection", new DependencyInfection()));
            _menu.Add(new ItemDoMenu(4, "Proxy", new Proxy()));

        }

        public void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("\n*******************************************************\n");
            foreach (var itemDoMenu in _menu) itemDoMenu.Imprimir();
            Console.WriteLine("\nDigite o número de um dos menus acima ou -1 para sair: \n");
        }

        public void ExecutarMenuSelecionado(int numeroDoMenuSelecionado)
        {
            var menuParaExecutar = _menu.Where(m => m.Numero == numeroDoMenuSelecionado).SingleOrDefault();

            if (menuParaExecutar != null) menuParaExecutar.Executar();
            else if(numeroDoMenuSelecionado!=-1) Console.WriteLine("Menu Inválido");
        }
    }

    public class ItemDoMenu
    {
        public int Numero { get; set; }

        private string _titulo;
        private IExecutavel _executavel;

        public ItemDoMenu(int numero, string titulo, IExecutavel executavel)
        {
            Numero = numero;
            _titulo = titulo;
            _executavel = executavel;
        }

        public void Imprimir()
        {
            Console.WriteLine("{0} - {1}", Numero, _titulo);
        }

        public void Executar()
        {
            Console.Clear();
            _executavel.Executar();
        }
    }
}
