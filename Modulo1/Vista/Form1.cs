using Entidades_Clases;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona _persona;
        //Registramos  y le pasamos al datagried
        List<Persona> listaPersonas = new List<Persona>();
        private void CrearButton_Click(object sender, EventArgs e)
        {
            _persona = new Persona();//Cada que registremos un nuevo objeto este se reinicia y queda nullo, lo hacemos basicamente para liberar memoria y evitar errores

            _persona.Nombre = NombreTextBox.Text;
            _persona.Estatura = Convert.ToDecimal(EstaturaTextBox.Text);
            _persona.Edad = DevolverEdad(NacimientoDateTimePicker.Value);//Le pasamos el metodo para que calcule la edad
            _persona.Genero = GeneroTextBox.Text;
            _persona.FechaNacimiento = NacimientoDateTimePicker.Value;

            EdadTextBox.Text = _persona.Edad.ToString();//Convertimos a string para presentarlo y se presente en el texbox de la edad

            //Le pasamos a la lista el mismo tipo de datos con el que lo hemos declarado 
            listaPersonas.Add(_persona);//Se ira alimentando con cada registro que vayamos creando
            PersonaBindingSource.DataSource = null;//LIMPIEZA
            PersonaBindingSource.DataSource = listaPersonas;//REGISTRO NUEVO
            Limpiar();
            NombreTextBox.Focus();//Pasando el cursor al primer text

            //YA NO ALIMENTAMOS LA LISTA DE ESTA MANERA
            //PersonasDataGridView.DataSource = null;//Cada que llenemos la lista, vaciaremos el data y luego pasamos de nuevo la lista

            //PersonasDataGridView.DataSource = listaPersonas;//Alimenta la collecion el .datasource
        }


        //LIMEZA DE TEXTBOX
        private void Limpiar()
        {
            _persona = null;
            NombreTextBox.Text = string.Empty;
            EstaturaTextBox.Text = string.Empty;
            EdadTextBox.Clear();
            GeneroTextBox.Clear();
            NacimientoDateTimePicker.Value = DateTime.Now;
        }
        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_persona.DevolverDatosDeLaPersona());
        }


        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento >= fechaActual)//Si la fecha de nacimiento es menor a la fecha actual retorna 0, porque no es posible
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;//RESTAMOS EL AÑO ACTUAL, DEL AÑO DE NACIMIENTO, ASI SACAMOS AÑOS
                //SI LA PERSONA CUMPLE MESES DESPUES DEL MES EN DONDE ESTAMOs
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    edad--;
                }
                return edad;
            }

        }
    }
}