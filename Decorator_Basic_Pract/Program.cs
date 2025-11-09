using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Basic_Pract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IMensaje mensaje = new MensajeTexto();
            
            
            
            mensaje = new MensajeConFirma(mensaje);

            
            mensaje = new MensajeConFecha(mensaje);

            

            mensaje = new MensajeCifrado(mensaje);
            
            
            mensaje.Enviar("Hola mundo desde el patrón Decorator - Práctica!");
        }
    }
}
