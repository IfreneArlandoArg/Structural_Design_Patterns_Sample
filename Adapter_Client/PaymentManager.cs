using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter_Client
{
    public class PaymentManager
    {
        public Usuario usuario { get; set; }

        List<IPago> Pagos { get;  }


        public PaymentManager(Usuario pUsuario)
        {
                usuario = pUsuario;
                Pagos = new List<IPago>();
        }

        public void AgregarPago(IPago pago)
        {
            Pagos.Add(pago);
        }



    }
}