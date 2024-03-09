using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.Encapsulamiento
{
    public class CuentaBancaria
    {
        private string titular;  // encapsula los datos a un nivel privado
        private decimal saldo;

        public string Titular
        {
            get { return titular; }       // los establece publicos para poder acceder despues a ellos 
            set { titular = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Depositar(decimal cantidad)
        {
            saldo += cantidad;                                  ////Deposita
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad <= saldo)                              ///retira
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente saldo en la cuenta.");
            }
        }
    }
}
