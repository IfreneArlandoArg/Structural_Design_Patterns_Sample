using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pract_2
{
    public class MensajeConFecha : MensajeDecorador
    {
        public MensajeConFecha(IMensaje mensaje) : base(mensaje)
        {
        }

        string AgregarFecha(string contenido)
        {
            return $"{DateTime.Now}\n\n{contenido}";
        }
        public override void Enviar(string contenido)
        {
            mensaje.Enviar(AgregarFecha(contenido));
        }
    }
}