using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPract3
{
    public class MensajeConFirma : MensajeDecorator
    {
        public MensajeConFirma(IMensaje mensaje) : base(mensaje)
        {
        }

        string AgregarFirma(string contenido)
        {
            return contenido + "\n\nAtentamente,\nIFRENE, Arlando A.";
        }

        public override void Enviar(string contenido)
        {
            mensaje.Enviar(AgregarFirma(contenido));
        }
    }
}