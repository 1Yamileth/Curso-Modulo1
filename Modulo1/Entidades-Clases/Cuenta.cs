using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clases
{
    public class Cuenta
    {
        public string Codigo { get; set; }
        public DateTime FechaApertura { get; set; }
        public decimal Saldo { get; set; }
        public Cliente ClienteCuenta { get; set; } /*Es una propiedad e esta clase del tipo de la clase "cliente"*/
        public string Estados { get; set; }

        public Cuenta()
        {
        }

        public Cuenta(string codigo, DateTime fechaApertura, decimal saldo, Cliente clienteCuenta, string estados)
        {
            Codigo = codigo;
            FechaApertura = fechaApertura;
            Saldo = saldo;
            ClienteCuenta = clienteCuenta;
            Estados = estados;
        }

        //metodo deposito
        public void Depositar(decimal monto)
        {
            Saldo += monto;//Actualizando el slado

        }

        //metodo 
        public  bool Retirar(decimal monto)
        {
            bool puedeRetirar = false;
            if (Saldo == 0 ||  Saldo<monto)
            {
                puedeRetirar = false;

            }
            else
            {
                puedeRetirar = true;
                Saldo = Saldo - monto;
            }

            return puedeRetirar;
        }

    }
}
