using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pract_2
{
    public class MensajeTexto : IMensaje
    {
        public void Enviar(string contenido)
        {
            Console.WriteLine($"Mensaje Texto ....\n\n {contenido}");
        }
    }
}