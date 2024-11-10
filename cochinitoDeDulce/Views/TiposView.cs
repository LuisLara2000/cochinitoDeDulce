using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cochinitoDeDulce.Views
{
    public partial class TiposView : Form,ITiposView
    {
        // ///////// //
        // ATRIBUTOS //
        // ///////// //
        private bool estoyEditando;
        private bool fueExitoso;
        private bool puedoEliminar;
        private string mensaje;
        private static TiposView instancia;// para el patron singleton
        private bool suscrito;
        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // Del modelo 
        public string IdTipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreTipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Solo en codigo
        public bool EstoyEditando { get => estoyEditando; set => estoyEditando = value; }
        public bool FueExitoso { get => fueExitoso; set => fueExitoso = value; }
        public bool PuedoEliminar { get => puedoEliminar; set => puedoEliminar = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }

        // De la vista
        public string TxtBuscarTipo { get => txtBuscarTipo.Text; set => txtBuscarTipo.Text = value; }
        public string TxtAgregarEditar { get => txtAgregarEditar.Text; set => txtAgregarEditar.Text = value; }
        public string LblAgregarEditar { get => lblAgregarEditar.Text; set => lblAgregarEditar.Text = value; }
        public string LblElimnarTipo { get => lblEliminarTipo.Text; set => lblEliminarTipo.Text = value; }
        public string CbEliminar { get => cbTipos.Text; set => cbTipos.Text = value; }
        public bool Suscrito { get => suscrito; set => suscrito=value; }

        public TiposView()
        {
            InitializeComponent();
            // asocio los eventos
            AsociarEventosDeLaVistaTipo();
            Estilos.EstilosGeneral.CargarEstilosGeneral(this);
            // oculto las ventanas que no quiero que se vean al inicio
            tbTipo.TabPages.Remove(tpAgregarEditarTipo);
            tbTipo.TabPages.Remove(tpEliminarTipo);
        }

        private void AsociarEventosDeLaVistaTipo()
        {
            // Ventana "Agregar Marca" //
            btnGuardarEditar.Click += delegate
            {
                if (!EstoyEditando)
                {
                    AgregarNuevoTipo_Event?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    EditarTipo_Event?.Invoke(this, EventArgs.Empty);
                }

                if (FueExitoso)
                {
                    tbTipo.TabPages.Remove(tpAgregarEditarTipo);
                    tbTipo.TabPages.Add(tpBuscarTipo);
                    txtAgregarEditar.Text = "";
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrAgregarTipo.Click += delegate
            {
                IrVentanaAgregarNuevoTipo_Event?.Invoke(this, EventArgs.Empty);
                tbTipo.TabPages.Remove(tpBuscarTipo);
                tbTipo.TabPages.Add(tpAgregarEditarTipo);
                tpAgregarEditarTipo.Text = "Agregar tipo";
                lblAgregarEditar.Text = "Ingrese el nombre de la nuevo tipo";
                btnGuardarEditar.Text = "Agregar";
            };
            btnRegresarEditarGuardar.Click += delegate
            {
                RegresarVentanaAgregarNuevoTipo_Event?.Invoke(this, EventArgs.Empty);
                tbTipo.TabPages.Remove(tpAgregarEditarTipo);
                tbTipo.TabPages.Add(tpBuscarTipo);
            };
            // Ventana "Eliminar Marca" //
            btnEliminarEliminar.Click += delegate
            {
                EliminarTipo_Event?.Invoke(this, EventArgs.Empty);
                if (FueExitoso)
                {
                    tbTipo.TabPages.Remove(tpEliminarTipo);
                    tbTipo.TabPages.Add(tpBuscarTipo);
                    MessageBox.Show(Mensaje);
                    cbTipos.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrEliminarTipo.Click += delegate
            {
                IrVentanaEliminarTipo_Event?.Invoke(this, EventArgs.Empty);
                if (PuedoEliminar)
                {

                    tbTipo.TabPages.Remove(tpBuscarTipo);
                    tbTipo.TabPages.Add(tpEliminarTipo);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }


            };
            btnCancelarEliminar.Click += delegate
            {
                RegresarVentanaEliminarTipo_Event?.Invoke(this, EventArgs.Empty);
                tbTipo.TabPages.Remove(tpEliminarTipo);
                tbTipo.TabPages.Add(tpBuscarTipo);
            };
            // Ventana "Editar Marca" //
            btnIrEditarTipo.Click += delegate {
                IrVentanaEditarTipo_Event?.Invoke(this, EventArgs.Empty);
                tbTipo.TabPages.Remove(tpBuscarTipo);
                tbTipo.TabPages.Add(tpAgregarEditarTipo);
                tpAgregarEditarTipo.Text = "Editar tipo";
                btnGuardarEditar.Text = "Editar";
            };
            // Ventana "Buscar Marca" //
            btnBuscar.Click += delegate
            {
                BuscarTipo_Event?.Invoke(this, EventArgs.Empty);
            };
        }
        // /////// //
        // EVENTOS //
        // /////// //
        public event EventHandler AgregarNuevoTipo_Event;
        public event EventHandler IrVentanaAgregarNuevoTipo_Event;
        public event EventHandler RegresarVentanaAgregarNuevoTipo_Event;
        public event EventHandler EliminarTipo_Event;
        public event EventHandler IrVentanaEliminarTipo_Event;
        public event EventHandler RegresarVentanaEliminarTipo_Event;
        public event EventHandler EditarTipo_Event;
        public event EventHandler IrVentanaEditarTipo_Event;
        public event EventHandler RegresarVentanaEditarTipo_Event;
        public event EventHandler BuscarTipo_Event;




        // /////// //
        // METODOS //
        // /////// //

        // Aqui se muestran las marcas en una tabla al ver la primera pantalla
        public void EstablecerValoresBindingSource(BindingSource tiposLista)
        {
            dgTipos.DataSource = tiposLista;
        }


        // Aqui se muestran las marcas en una lista para que escojas cual reemplazara a la que quieres eliminar
        public void EstablecerValoresComboBox(IEnumerable<TiposModel> tiposListaMenosLaQueVasAEliminar)
        {
            cbTipos.Items.Clear();
            foreach (var tipo in tiposListaMenosLaQueVasAEliminar)
            {
                cbTipos.Items.Add(tipo.NombreTipo);
            }
        }

        // PATRON SINGLETON, para que la ventana solo se invoke una vez y no existan duplicados
        public static TiposView ObtenerLaVentanaTipos(Form ventanaPadre)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed)
            {
                // creamos la ventana
                instancia = new TiposView();
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
