using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPract3
{
    public class MensajeTexto : IMensaje
    {
        public void Enviar(string contenido)
        {
            Console.WriteLine($"Enviando mensaje...\n\n{contenido}");
        }
    }
}