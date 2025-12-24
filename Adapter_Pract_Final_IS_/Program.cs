using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pract_Final_IS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPago pagoBanco = new Banco("Banco Nacional");

            pagoBanco.Pagar(987.98);

            pagoBanco = new AdapterMercadoPago();

            pagoBanco.Pagar(1234.56);

            
        }
    }
}
