using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pract_2
{
    public class MensajeConFirma : MensajeDecorador
    {
        public MensajeConFirma(IMensaje mensaje) : base(mensaje)
        {
        }

        string AgregarFirma(string contenido)
        {
            return contenido + "\n\nAtentamente,\nIfrene Arlando A";
        }

        public override void Enviar(string contenido)
        {
            mensaje.Enviar(AgregarFirma(contenido));
        }
    }
}