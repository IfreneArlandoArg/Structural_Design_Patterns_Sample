using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPract3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMensaje mensaje = new MensajeTexto();

            mensaje = new MensajeConFecha(mensaje);
            mensaje = new MensajeConFirma(mensaje);
            mensaje = new MensajeEncriptado(mensaje);


            mensaje.Enviar("Hola mundo desde el patrón Decorator - Práctica 3!");
        }
    }
}
