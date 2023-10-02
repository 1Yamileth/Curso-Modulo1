using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clases
{
    public class Movimiento
    {
        public Cuenta CuentaMovimiento { get; set; }
        public DateTime fechaMovimiento { get; set; }
        public decimal MontoMovimiento { get; set; }
        public TipoMovimiento Tipo { get; set; }

        public Movimiento()
        {
        }

        public Movimiento(Cuenta cuentaMovimiento, DateTime fechaMovimiento, decimal montoMovimiento, TipoMovimiento tipo)
        {
            CuentaMovimiento = cuentaMovimiento;
            this.fechaMovimiento = fechaMovimiento;
            MontoMovimiento = montoMovimiento;
            Tipo = tipo;
        }
    }
}
