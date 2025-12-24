using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite_PracticFinal
{
    public class MenuCategoria : MenuComponent
    {
        List<MenuComponent> _listMenuComponent;
        public MenuCategoria(string nombre)
        {
            Nombre = nombre;
            _listMenuComponent = new List<MenuComponent>();
        }

        public override void AgregarMenuComponent(MenuComponent pMenuComponent) 
        { 
          _listMenuComponent.Add(pMenuComponent);
        }
        public override void Mostrar()
        {
            Console.WriteLine($"Categoria Menu : {Nombre}");
            foreach (var menuComponent in _listMenuComponent) 
            { 
               menuComponent.Mostrar();
            }
        }
    }
}