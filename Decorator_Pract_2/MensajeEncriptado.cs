using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pract_2
{
    public class MensajeEncriptado : MensajeDecorador
    {
        public MensajeEncriptado(IMensaje mensaje) : base(mensaje)
        {
        }

        string Encriptar(string contenido) 
        { 
           return Convert.ToBase64String(Encoding.UTF8.GetBytes(contenido));
        }

        public override void Enviar(string contenido)
        {
            mensaje.Enviar(Encriptar(contenido));
        }
    }
}