using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Pract_Final_IS_
{
    public class Banco : IPago
    {
        public string Nombre { get; set; }

        public Banco(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void Pagar(double monto)
        {
            Console.WriteLine($"Pagando {monto} a través del banco {Nombre}");
        }

    }
}