using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Client
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Usuario(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public override string ToString()
        {
            return $"Cliente: {Apellido}, {Nombre}";
        }

    }
}