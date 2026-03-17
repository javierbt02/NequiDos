using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NequiDos
{
    internal class CuentaNequi2
    {
        public string Duenio {  get; set; }
        public Guid NumeroDeCuenta { get; set; }
        public decimal Balance { get; set; }

        // Constructor

        public CuentaNequi2 (string duenio)
        {
            Duenio = duenio;
            NumeroDeCuenta = Guid.NewGuid();
            Balance = 0;
        }

        public string Depositar(decimal cantidad)
        {
            Balance += cantidad;
            return "Deposito exitoso!!";
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad > Balance)
            {
                MessageBox.Show("Balance Insuficiente.");
            }
            else
            {
                Balance -= cantidad;
                MessageBox.Show("Retiro Exitoso.");
            }
        }

        
    }
}
