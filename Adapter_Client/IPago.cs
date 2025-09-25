using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;

namespace Adapter_Client
{
    public interface IPago
    {
        string Nombre { get; set; }
        

        void Pagar(double monto);



    }



    public class PagoConTarjeta : IPago
    {
        public string Nombre { get; set; }
        public double Monto { get; set; }
        public TipoTarjeta Tipo { get; set; }

        public MarcaTarjeta Marca { get; set; }


        public PagoConTarjeta(string nombre)
        {
            Nombre = nombre;
            
            Monto = 0;

        }

        public void Pagar(double monto) 
        { 
            Monto = monto; 
        }


        public override string ToString()
        {
            if (Monto == 0)
                throw new Exception("Debe realizar un pago primero");
            return $"Banco: {Nombre} - Monto :{Monto}AR$ - ";
        }

    }

    public class MonederoElectronicoAdapter : IPago
    {
        public string Nombre { get; set; }
        

        MonederoElectronico monederoElectronico;
        

        public MonederoElectronicoAdapter(string nombre)
        {
              monederoElectronico = new MonederoElectronico(nombre);
             
        }

        public void Pagar(double monto)
        {
            monederoElectronico.EnviarPago(monto);
        }

       public override string ToString()
       {
            return monederoElectronico.ToString();
       }
    }

    public class MonederoElectronico 
    {
        public string Nombre { get; set; }
        
        public double Monto { get; set; }

        public MonederoElectronico(string nombre)
        {
           
            Nombre = nombre;
            
            Monto = 0;

        }

        public void EnviarPago(double monto) 
        { 
            
            if (monto <= 0)
                throw new Exception("El monto debe ser mayor a cero");


            Monto = monto;
            
        }

        public override string ToString()
        {
            if (Monto == 0)
                throw new Exception("Debe realizar un pago primero");
            return $"Monedero: {Nombre} - Monto :{Monto}AR$ - ";
        }

    }

}