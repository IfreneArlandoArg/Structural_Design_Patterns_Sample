using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Basic
{
    // Componente base
    public interface IMensaje
    {
        void Enviar(string contenido);
    }

    // Componente concreto
    public class MensajeTexto : IMensaje
    {
        public void Enviar(string contenido)
        {
            Console.WriteLine($"Enviando mensaje: {contenido}");
        }
    }

    // Decorador base
    public abstract class MensajeDecorador : IMensaje
    {
        protected IMensaje mensaje;
        public MensajeDecorador(IMensaje mensaje)
        {
            this.mensaje = mensaje;
        }

        public abstract void Enviar(string contenido);
    }

    // Decorador: Cifrado
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

    // Decorador: Compresión
    public class MensajeComprimido : MensajeDecorador
    {
        public MensajeComprimido(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string contenido)
        {
            Console.WriteLine("Comprimiendo mensaje...");
            byte[] bytes = Encoding.UTF8.GetBytes(contenido);
            using (var output = new MemoryStream())
            {
                using (var gzip = new GZipStream(output, CompressionMode.Compress))
                {
                    gzip.Write(bytes, 0, bytes.Length);
                }
                mensaje.Enviar($"[Mensaje comprimido: {output.ToArray().Length} bytes]");
            }
        }
    }

    // Decorador: Log
    public class MensajeLog : MensajeDecorador
    {
        public MensajeLog(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string contenido)
        {
            Console.WriteLine($"Log: enviando mensaje '{contenido}' a las {DateTime.Now}");
            mensaje.Enviar(contenido);
        }
    }
}
