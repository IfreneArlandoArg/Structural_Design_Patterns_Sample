using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriaMenu menu = new CategoriaMenu("Menú Principal");
            CategoriaMenu bebidas = new CategoriaMenu("Bebidas");
            bebidas.Agregar(new Plato("Coca-Cola"));
            bebidas.Agregar(new Plato("Agua"));

            CategoriaMenu comidas = new CategoriaMenu("Comidas");
            comidas.Agregar(new Plato("Pizza"));
            comidas.Agregar(new Plato("Hamburguesa"));

            menu.Agregar(bebidas);
            menu.Agregar(comidas);

            menu.Mostrar();
        }
    }
}
