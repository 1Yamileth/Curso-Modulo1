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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SincronoButton_Click(object sender, EventArgs e)
        {
            HornearPollo();
            MessageBox.Show("Listo, Esta El Pollo Hecho");
        }

        private void AsincronoButton_Click(object sender, EventArgs e)
        {
            HornearPolloAsync();
            MessageBox.Show("Listo, Esta El Pollo Hecho");
        }

        private void HornearPollo()
        {
            Thread.Sleep(8000);
        }

        private Task HornearPolloAsync()
        {
            return Task.Delay(8000);
        }


        private async Task<decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal suma = await Task.Run(() => /*El "await" lo que hace es esperar a que la tarea finalice, una vez que termine se amnda a travez de la variable*/
            {
                return num1 + num2;
            });
            return suma;
        }

        private async void SumanButton_Click(object sender, EventArgs e)
        {
            decimal resultado = await  SumarAsync(5, 20); //el llamado de metodos asincronos se hace con el "await" siempre

            MessageBox.Show($"La suma es: {resultado} ");
        }
    }
}
