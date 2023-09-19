using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clases
{
    public class Persona
    {
        //Atributos:Caracteristica de mi clase. SIEMPRE EN PRIVADO (Se usan cuando se hace x operacion interna en la clase, de lo contrario PROPIEDADES)
        // private string _nombre;//LETRA INICIAL MINUSCULA O CON GUION BAJO
        //private decimal estatura;
        //private int edad;
        //private string genero;
        //private DateTime fechaNacimiento;




        //Propiedades:Nos sirven para dar o brindar informacion al exterior de clase. Mediante estas se obtienen la informacion de los atributos
        public string Nombre { get; set; }//LETRA INICIAL MAYUSCULA
        public decimal Estatura { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }


        //Constructores: Se encarga de pasar valores al momento de instancia mi clase o objeto
        //SOBRECARGA: ayuda a tener diferentes parametros(no pueden ir con la misma cantidad de parametros) cuando tenemos metodos, acciones y/o constructores con el mismo nombre
        public Persona()
        {
        }

        public Persona(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

        public Persona(string nombre, decimal estatura, int edad, string genero, DateTime fechaNacimiento)
        {

            Nombre = nombre;
            Estatura = estatura;
            Edad = edad;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
        }



        //Metodos(funciones, acciones)
        public string DevolverDatosDeLaPersona()
        {
            return "Nombre: " + Nombre + ", Edad: " + Edad + ", Genero: " + Genero ;
        }

    }
}
