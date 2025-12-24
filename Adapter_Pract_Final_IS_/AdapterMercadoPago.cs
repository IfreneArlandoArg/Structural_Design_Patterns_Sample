using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Pract_Final_IS_
{
    public class AdapterMercadoPago : IPago
    {
        MercadoPago mercadoPago = new MercadoPago();

        public void Pagar(double monto)
        {
            mercadoPago.ProcesarPago(monto);
        }
    }
}