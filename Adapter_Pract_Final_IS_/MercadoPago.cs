using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Pract_Final_IS_
{
    public class MercadoPago
    {
        public void ProcesarPago(double monto)
        {
            Console.WriteLine($"Pagando {monto} a través de MercadoPago");
        }
    }
}