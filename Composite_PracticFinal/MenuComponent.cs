using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite_PracticFinal
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string nombre)
        {
            Nombre = nombre;
        }

        public override void AgregarMenuComponent(MenuComponent pMenuComponent)
        {
            Console.WriteLine($"       No se puede agregar menuItem a MenuItem");
        }

        public override void Mostrar()
        {
            Console.WriteLine($"       Menu Item : {Nombre}");
        }
    }

    public abstract class MenuComponent
    {
        public string Nombre { get; set; }

        public abstract void AgregarMenuComponent(MenuComponent pMenuComponent);
        public abstract void Mostrar(); 
    }
}