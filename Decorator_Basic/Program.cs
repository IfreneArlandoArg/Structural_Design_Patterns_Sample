using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mensaje simple
            IMensaje mensaje = new MensajeTexto();

            // Decorar con log
            mensaje = new MensajeLog(mensaje);

            // Decorar con cifrado
            mensaje = new MensajeCifrado(mensaje);

            // Decorar con compresión
            mensaje = new MensajeComprimido(mensaje);

            // Enviar mensaje decorado
            mensaje.Enviar("Hola mundo desde el patrón Decorator!");
        }
    }
}
