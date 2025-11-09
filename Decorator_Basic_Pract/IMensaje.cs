using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Basic_Pract
{
    public interface IMensaje
    {
        void Enviar(string contenido);
    }


    public class MensajeTexto : IMensaje
    {
        public void Enviar(string contenido)
        {
            Console.WriteLine($"Enviando mensaje: {contenido}");
        }
    }


    public abstract class MensajeDecorador : IMensaje
    {
        protected IMensaje mensaje;
        public MensajeDecorador(IMensaje mensaje)
        {
           this.mensaje = mensaje;
        }
        public abstract void Enviar(string contenido);
    }



    public class MensajeCifrado : MensajeDecorador
    {
        public MensajeCifrado(IMensaje mensaje) : base(mensaje) { }
        public override void Enviar(string contenido)
        {
            string cifrado = Convert.ToBase64String(Encoding.UTF8.GetBytes(contenido));
            Console.WriteLine("Cifrando mensaje...");
            mensaje.Enviar(cifrado);
        }
    }

    public class MensajeConFirma : MensajeDecorador
    {
        public MensajeConFirma(IMensaje mensaje) : base(mensaje) { }
        public override void Enviar(string contenido)
        {
            string contenidoConFirma = contenido + "\n\n-- Enviado desde mi aplicación";
            Console.WriteLine("Agregando firma al mensaje...");
            mensaje.Enviar(contenidoConFirma);
        }
    }

    public class MensajeConFecha : MensajeDecorador
    {
        public MensajeConFecha(IMensaje mensaje) : base(mensaje) { }
        public override void Enviar(string contenido)
        {
            string contenidoConFecha = $"[{DateTime.Now}] {contenido}";
            Console.WriteLine("Agregando fecha al mensaje...");
            mensaje.Enviar(contenidoConFecha);
        }
    }



}