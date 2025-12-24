using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_PracticFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuComponent menuPrincipal = new MenuCategoria("Menu Principal");

            MenuComponent MenuBebida = new MenuCategoria("Bebidas");
            
            MenuBebida.AgregarMenuComponent(new MenuItem("Coca-Cola"));
            MenuBebida.AgregarMenuComponent(new MenuItem("Agua"));

            MenuComponent MenuComida = new MenuCategoria("Comidas");
            MenuComida.AgregarMenuComponent(new MenuItem("Pizza"));
            MenuComida.AgregarMenuComponent(new MenuItem("Hamburguesa"));
            menuPrincipal.AgregarMenuComponent(MenuBebida);
            menuPrincipal.AgregarMenuComponent(MenuComida);

            menuPrincipal.Mostrar();
        }
    }
}
