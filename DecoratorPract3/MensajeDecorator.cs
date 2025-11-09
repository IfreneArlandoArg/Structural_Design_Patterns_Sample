using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPract3
{
    public abstract class MensajeDecorator : IMensaje
    {
        protected IMensaje mensaje;

        protected MensajeDecorator(IMensaje mensaje)
        {
            this.mensaje = mensaje;
        }
        public abstract void Enviar(string contenido);
        
    }
}