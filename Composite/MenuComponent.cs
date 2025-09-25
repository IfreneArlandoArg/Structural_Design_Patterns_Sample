using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    // Componente
    public abstract class MenuComponent
    {
        public string Nombre { get; set; }
        public abstract void Mostrar();
    }

    // Hoja
    public class Plato : MenuComponent
    {
        public Plato(string nombre) => Nombre = nombre;
        public override void Mostrar() => Console.WriteLine($"Plato: {Nombre}");
    }

    // Compuesto
    public class CategoriaMenu : MenuComponent
    {
        private List<MenuComponent> items = new List<MenuComponent>();

        public CategoriaMenu(string nombre) => Nombre = nombre;

        public void Agregar(MenuComponent item) => items.Add(item);

        public override void Mostrar()
        {
            Console.WriteLine($"Categoría: {Nombre}");
            foreach (var item in items)
                item.Mostrar();
        }
    }

}