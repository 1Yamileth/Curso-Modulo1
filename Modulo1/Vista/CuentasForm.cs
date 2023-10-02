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
    public partial class CuentasForm : Form
    {
        public CuentasForm()
        {
            InitializeComponent();
        }
        //guarda en memoria los tipos de movimiento mostrados en combo box
        List<TipoMovimiento> tipoMovimientoLista = new List<TipoMovimiento>();
        Cliente _cliente;
        Cuenta _cuenta;
        Movimiento _movimiento;
        List<Movimiento> listaMovimientos = new List<Movimiento>();


        private void CuentasForm_Load(object sender, EventArgs e)
        {
            //COMO NO ESTAMOS USANDO DB, CARGAMOS EN MEMORIA ESTOS TIPOS
            /*Para que al momento de cargar el proyecto  nos aparezcan los datos deseados, como el estado de la cuenta, entre otras cosas, hacemos lo siguiente*/
            tipoMovimientoLista.Add(new TipoMovimiento("Deposito"));
            tipoMovimientoLista.Add(new TipoMovimiento("Retiro"));

            TipoMovimientoComboBox.DataSource = tipoMovimientoLista;//LE asignamos al combo los datos
            TipoMovimientoComboBox.DisplayMember = "NombreMovimiento";//Es el nombre de la Propiedad, asi mostamos los datos guardados en ella.
        }

        private void AperturarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IdentidadTxt.Text))
            {
                NombreErrorProvider.SetError(IdentidadTxt, "Ingrese una identidad");//ESTE "SET" pide dos parametros, donde se muestra el error y lo que contiene el error
                IdentidadTxt.Focus();
                return;//Termina y no sigue con las demas lineas ya llenas. USAMOS PARA AHORRAR MEMORIA
            }
            NombreErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreTxt.Text))
            {
                NombreErrorProvider.SetError(NombreTxt, "Ingrese un nombre");
                NombreTxt.Focus();
                return;
            }
            NombreErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(GeneroComboBox.Text))
            {
                NombreErrorProvider.SetError(GeneroComboBox, "Seleccione el genero");
                return;
            }
            NombreErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(CodigoCuentaTxt.Text))
            {
                NombreErrorProvider.SetError(CodigoCuentaTxt, "Ingrese un codigo");
                CodigoCuentaTxt.Focus();
                return;
            }
            NombreErrorProvider.Clear();

            //CREANDO CLIENTE
            _cliente = new Cliente();
            _cliente.Identidad = IdentidadTxt.Text;
            _cliente.Nombre = NombreTxt.Text;
            _cliente.FechaNacimiento = NacimientoDateTimePicker.Value;
            _cliente.Genero = GeneroComboBox.Text;
            //Mando los datos necesarios a la clase cuenta, cuando se abre una nueva cuenta
            _cuenta = new Cuenta(CodigoCuentaTxt.Text, DateTime.Now, 0.00M, _cliente, "Activa");
            SaldoTxt.Text = _cuenta.Saldo.ToString();//Le estamos pasando el salgo al .text desde la clase "cuenta"



        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (MontoTxt.Text == string.Empty)
            {
                NombreErrorProvider.SetError(MontoTxt, "Ingrese un monto");
                MontoTxt.Focus();
                return;
            }

            if (TipoMovimientoComboBox.Text == string.Empty)
            {
                NombreErrorProvider.SetError(TipoMovimientoComboBox, "Seleccione el tipo de movimiento");
                TipoMovimientoComboBox.Focus();
                return;
            }

            if (_cliente== null && _cuenta==null)
            {
                NombreErrorProvider.SetError(NombreTxt, "No se ha aperturado la cuenta ");
                NombreTxt.Focus();
                return;
            }
            decimal monto =Convert.ToDecimal(MontoTxt.Text);



            //VIENDO EL TIPO DE MOVIMIENTO
            if (TipoMovimientoComboBox.Text == "Deposito")
            {
                _cuenta.Depositar(monto);//Se hac el deposito y registra el mov
                //REGISTRAMOS MOVIMIENTO
                _movimiento = new Movimiento(_cuenta, DateTime.Now, monto, new TipoMovimiento(TipoMovimientoComboBox.SelectedText/*Selecciona el valor dentro del combobox*/));

                //MOSTRAMOS EL MOVIMIENTO EN LA LISTA DE VISTA
                //listaMovimientos.Add(_movimiento);
                
                //Le pasamos el recien movimiento hecho
                MovimientosListBox.Items.Add("Deposito a la cuenta N. "+ _cuenta.Codigo + " por la cantidad de L. "+ _movimiento.MontoMovimiento + "con fecha: "
                                            + _movimiento.fechaMovimiento.ToShortDateString());

                //vemos el saldo desde la clase cuenta
                SaldoTxt.Text= _cuenta.Saldo.ToString();


            }
            else if(TipoMovimientoComboBox.Text == "Retiro")
            {
                bool retiro= _cuenta.Retirar(monto);//Le pasamos el metodo a la variable y al metodo le pasamos el monto a retirar

                if (retiro)
                {
                    _movimiento = new Movimiento(_cuenta, DateTime.Now, monto, new TipoMovimiento(TipoMovimientoComboBox.SelectedText/*Selecciona el valor dentro del combobox*/));

                    MovimientosListBox.Items.Add("Retiro a la cuenta N. " + _cuenta.Codigo + " por la cantidad de L. " + _movimiento.MontoMovimiento + "con fecha: "
                                            + _movimiento.fechaMovimiento.ToShortDateString());

                    //Actualizando saldos
                    SaldoTxt.Text = _cuenta.Saldo.ToString();
                }else
                {
                    MessageBox.Show($"La cuenta N. {_cuenta.Codigo} no tiene suficiente saldo para realizar el retiro ");
                }

            }



        }
    }
}
