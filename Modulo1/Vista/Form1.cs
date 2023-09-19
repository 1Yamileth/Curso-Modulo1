using Entidades_Clases;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona _persona = new Persona();

        private void CrearButton_Click(object sender, EventArgs e)
        {
            _persona.Nombre = NombreTextBox.Text;
            _persona.Estatura = Convert.ToDecimal(EstaturaTextBox.Text);
            _persona.Edad = DevolverEdad(NacimientoDateTimePicker.Value);//Le pasamos el metodo para que calcule la edad
            _persona.Genero = GeneroTextBox.Text;
            _persona.FechaNacimiento = NacimientoDateTimePicker.Value;
            
            EdadTextBox.Text = _persona.Edad.ToString();//Convertimos a string para presentarlo y se presente en el texbox de la edad
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_persona.DevolverDatosDeLaPersona());
        }


        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual= DateTime.Now;
            int edad = 0;

            if (fechaNacimiento>= fechaActual)//Si la fecha de nacimiento es menor a la fecha actual retorna 0, porque no es posible
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;//RESTAMOS EL AÑO ACTUAL, DEL AÑO DE NACIMIENTO, ASI SACAMOS AÑOS
                //SI LA PERSONA CUMPLE MESES DESPUES DEL MES EN DONDE ESTAMOs
                if (fechaNacimiento.Month> fechaActual.Month)
                {
                    edad--;
                }
                return edad;
            }

        }
    }
}