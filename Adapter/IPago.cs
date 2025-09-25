using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    // Interfaz esperada
    public interface IPago
    {
        void Pagar(double monto);
    }

    // Clase incompatible
    public class PayPal
    {
        public void SendPayment(double amount) =>
            Console.WriteLine($"Pagando {amount} con PayPal");
    }

    // Adaptador
    public class PayPalAdapter : IPago
    {
        private PayPal _paypal = new PayPal();
        public void Pagar(double monto) => _paypal.SendPayment(monto);
    }


}