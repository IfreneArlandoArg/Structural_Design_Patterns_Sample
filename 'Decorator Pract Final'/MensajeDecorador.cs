using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Decorator_Pract_Final_
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