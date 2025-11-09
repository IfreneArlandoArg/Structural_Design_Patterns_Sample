using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPract3
{
    public class MensajeConFecha : MensajeDecorator
    {
        public MensajeConFecha(IMensaje mensaje) : base(mensaje)
        {
        }

        string AgregarFecha( string contenido) 
        {
            return  $"{DateTime.Now}\n\n{contenido}" ;
        }

        public override void Enviar(string contenido)
        {
            mensaje.Enviar(AgregarFecha(contenido));
        }
    }
}