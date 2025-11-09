using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pract_2
{
    public abstract class MensajeDecorador : IMensaje
    {
        protected IMensaje mensaje;

        protected MensajeDecorador(IMensaje mensaje)
        {
            this.mensaje = mensaje;
        }

        public abstract void Enviar(string contenido);
        
    }
}