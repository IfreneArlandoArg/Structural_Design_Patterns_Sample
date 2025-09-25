using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPago pago = new PayPalAdapter();
            pago.Pagar(100.50);
        }
    }
}
