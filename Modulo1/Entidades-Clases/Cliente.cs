using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clases
{
    public class Cliente : Persona /*LA CLASE CLIENTE HEREDA TODO LO QUE TIENE LA CLASE PERSONA*/
    {
        public string Identidad { get; set; }

        public Cliente()
        {
        }

        public Cliente(string identidad)
        {
            Identidad = identidad;
        }
    }
}
