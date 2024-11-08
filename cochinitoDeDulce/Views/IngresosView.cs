using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cochinitoDeDulce.Views
{
    public partial class IngresosView : Form,IIngresosView
    {
        private static IngresosView instancia;
        private bool editando;
        private bool exitoso;
        private string mensaje;
        private bool suscrito;

        public int IdIngreso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Monto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Origen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TxtBuscarIngreso { get => txtBuscarIngreso.Text; set => txtBuscarIngreso.Text=value; }
        public string TxtAgregarMonto { get => txtAgregarMonto.Text; set => txtAgregarMonto.Text=value; }
        public string TxtAgregarOrigen { get => txtAgregarOrigen.Text; set => txtAgregarOrigen.Text=value; }
        public string LblAgregarEditar { get => lblAgregarEditar.Text; set => lblAgregarEditar.Text=value; }
        public bool Editando { get => editando; set => editando=value; }
        public bool Exitoso { get => exitoso; set => exitoso=value; }
        public string Mensaje { get => mensaje; set => mensaje=value; }
        public bool Suscrito { get => suscrito; set => suscrito=value; }

        public IngresosView()
        {
            InitializeComponent();
            // acomodo las paginas
            tbIngresos.TabPages.Remove(tpAgregarEditarIngresos);
            // asociar eventos
            AsociarEventosDeLaVista();
        }

        private void AsociarEventosDeLaVista()
        {
            btnBuscar.Click += delegate
            {
                BuscarIngreso_Event?.Invoke(this, EventArgs.Empty);
            };
            btnIrAgregarMarca.Click += delegate
            {
                IrVentanaAgregarNuevoIngreso_Event?.Invoke(this, EventArgs.Empty);
                tbIngresos.TabPages.Remove(tpBuscarIngresos);
                tbIngresos.TabPages.Add(tpAgregarEditarIngresos);
                btnGuardarEditar.Text = "Agregar";
                tpAgregarEditarIngresos.Text = "Agregar Ingreso";
            };
            btnGuardarEditar.Click += delegate
            {
                if(Editando)
                {
                    EditarIngreso_Event?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    AgregarNuevoIngreso_Event?.Invoke(this, EventArgs.Empty);
                }
                if(Exitoso)
                {
                    tbIngresos.TabPages.Remove(tpAgregarEditarIngresos);
                    tbIngresos.TabPages.Add(tpBuscarIngresos);
                    MessageBox.Show(Mensaje);
                    txtAgregarMonto.Text = "";
                    txtAgregarOrigen.Text = "";
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrEditarMarca.Click += delegate
            {
                IrVentanaEditarIngreso_Event?.Invoke(this, EventArgs.Empty);
                tbIngresos.TabPages.Remove(tpBuscarIngresos);
                tbIngresos.TabPages.Add(tpAgregarEditarIngresos);
                btnGuardarEditar.Text = "Editar";
                tpAgregarEditarIngresos.Text = "Editar Ingreso";
            };
            btnRegresarEditarGuardar.Click += delegate
            {
                RegresarVentanaAgregarNuevoIngreso_Event.Invoke(this, EventArgs.Empty);
                tbIngresos.TabPages.Remove(tpAgregarEditarIngresos);
                tbIngresos.TabPages.Add(tpBuscarIngresos);
            };
            btnEliminarIngreso.Click += delegate
            {
                EliminarIngreso_Event.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Mensaje);
            };
        }
        public void EstablecerBindingSource(BindingSource ingresosLista)
        {
            dgIngresos.DataSource = ingresosLista;
        }
        public event EventHandler AgregarNuevoIngreso_Event;
        public event EventHandler IrVentanaAgregarNuevoIngreso_Event;
        public event EventHandler RegresarVentanaAgregarNuevoIngreso_Event;
        public event EventHandler EditarIngreso_Event;
        public event EventHandler IrVentanaEditarIngreso_Event;
        public event EventHandler EliminarIngreso_Event;
        public event EventHandler BuscarIngreso_Event;

        // singleton
        public static IngresosView ObtenerLaVentanaIngresos(Form ventanaPadre)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed)
            {
                // creamos la ventana
                instancia = new IngresosView();
                // hacemos que la ventana "categorias" este dentro de la ventana principal
                instancia.MdiParent = ventanaPadre;
                // le quitamos los bordes
                instancia.FormBorderStyle = FormBorderStyle.None;
                // hacemos que ocupe todo el espacio
                instancia.Dock = DockStyle.Fill;
            }
            else
            {
                // en caso de que ya exista
                // lo desminimizamos en caso de que este minimiazdo
                if (instancia.WindowState == FormWindowState.Minimized)
                    instancia.WindowState = FormWindowState.Normal;
                // y lo traemos al frente
                instancia.BringToFront();
            }
            // regresamos la ventana
            return instancia;
        }


    }
}
