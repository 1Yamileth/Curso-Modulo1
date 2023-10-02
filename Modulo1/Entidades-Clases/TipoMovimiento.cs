using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clases
{
    public class TipoMovimiento
    {
        public string  NombreMovimiento { get; set; }

        public TipoMovimiento()
        {
        }

        public TipoMovimiento(string nombreMovimiento)
        {
            NombreMovimiento = nombreMovimiento;
        }
    }
}
