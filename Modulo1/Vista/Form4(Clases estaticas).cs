using Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form4_Clases_estaticas_ : Form
    {
        public Form4_Clases_estaticas_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSTANCIANDO CLASE ESTATICA
            // Calculadora cal = new Calculadora();//No se puede porque es una clase ESTATICA

            //CAPTURANDO ERRORES
            try
            {
                //Cuando la clase es estatica no es estatica se puede acceder mediante la clase a los metodos, no se necesita instanciar
                int val1 = Convert.ToInt32(Val1txt.Text);
                int val2 = Convert.ToInt32(Val2Txt.Text);

                Calculadora.Dividir(val1, val2);

                MessageBox.Show(Math.Sqrt(9).ToString());
            }catch (Exception ex) { //CAPTURA TODO TIPO DE EXCEPCIONES
                 MessageBox.Show(ex.Message);//MOSTAMOS EL ERROR CON EL ex.message
            }


            //MOSTRANDO ERRORES INDIVIDUALES

            //catch (DivideByZeroException ex ) //capturamos el error aqui              
            //{
            //    MessageBox.Show(ex.Message);//MOSTAMOS EL ERROR CON EL ex.message
            //}
            //catch (System.FormatException ex)//Excepcion indicada para cuando nos ingresan un formato diferente al pedido
            //{
            //    MessageBox.Show("NO SE PUEDE CONVERTIR EL VALOR INGRESADO A ENTERO");
            //}
            //catch (OverflowException ex)//Excepcion indicada para cuando nos ingresan un formato mas grande que el fomrato que pedimos
            //{
            //    MessageBox.Show("EL VALOR INGRESADO ES DEMASIADO GRANDE");
            //}

        }

    }
}
