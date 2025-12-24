using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Decorator_Pract_Final_
{
    public class MensajeTexto : IMensaje
    {
        public void Enviar(string contenido)
        {
            Console.WriteLine($"Enviando mensaje...\n\n{contenido}");
        }
    }
}