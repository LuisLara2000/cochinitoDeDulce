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
    public partial class LugaresView : Form,ILugaresView
    {
        // ///////// //
        // ATRIBUTOS //
        // ///////// //
        private bool estoyEditando;
        private bool fueExitoso;
        private bool puedoEliminar;
        private string mensaje;
        private static LugaresView instancia;// para el patron singleton

        // /////////// //
        // PROPIEDADES //
        // /////////// //Lugar

        // Del modelo 
        public string IdLugar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreLugar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Solo en codigo
        public bool EstoyEditando { get => estoyEditando; set => estoyEditando = value; }
        public bool FueExitoso { get => fueExitoso; set => fueExitoso = value; }
        public bool PuedoEliminar { get => puedoEliminar; set => puedoEliminar = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }

        // De la vista
        public string TxtBuscarLugar { get => txtBuscarMarca.Text; set => txtBuscarMarca.Text = value; }
        public string TxtAgregarEditar { get => txtAgregarEditar.Text; set => txtAgregarEditar.Text = value; }
        public string LblAgregarEditar { get => lblAgregarEditar.Text; set => lblAgregarEditar.Text = value; }
        public string LblElimnarLugar { get => lblEliminarLugar.Text; set => lblEliminarLugar.Text = value; }
        public string CbEliminar { get => cbLugares.Text; set => cbLugares.Text = value; }

        public LugaresView()
        {
            InitializeComponent();
            // asocio los eventos
            AsociarEventosDeLaVistaLugar();
            // oculto las ventanas que no quiero que se vean al inicio
            tbLugar.TabPages.Remove(tpAgregarEditarLugar);
            tbLugar.TabPages.Remove(tpEliminarLugar);
        }

        private void AsociarEventosDeLaVistaLugar()
        {
            // Ventana "Agregar Marca" //
            btnGuardarEditar.Click += delegate
            {
                if (!EstoyEditando)
                {
                    AgregarNuevoLugar_Event?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    EditarLugar_Event?.Invoke(this, EventArgs.Empty);
                }

                if (FueExitoso)
                {
                    tbLugar.TabPages.Remove(tpAgregarEditarLugar);
                    tbLugar.TabPages.Add(tpBuscarLugar);
                    txtAgregarEditar.Text = "";
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrAgregarLugar.Click += delegate
            {
                IrVentanaAgregarNuevoLugar_Event?.Invoke(this, EventArgs.Empty);
                tbLugar.TabPages.Remove(tpBuscarLugar);
                tbLugar.TabPages.Add(tpAgregarEditarLugar);
                tpAgregarEditarLugar.Text = "Agregar Lugar";
                lblAgregarEditar.Text = "Ingrese el nombre de la nuevo Lugar";
                btnGuardarEditar.Text = "Agregar";
            };
            btnRegresarEditarGuardar.Click += delegate
            {
                RegresarVentanaAgregarNuevoLugar_Event?.Invoke(this, EventArgs.Empty);
                tbLugar.TabPages.Remove(tpAgregarEditarLugar);
                tbLugar.TabPages.Add(tpBuscarLugar);
            };
            // Ventana "Eliminar Lugar" //
            btnEliminarEliminar.Click += delegate
            {
                EliminarLugar_Event?.Invoke(this, EventArgs.Empty);
                if (FueExitoso)
                {
                    tbLugar.TabPages.Remove(tpEliminarLugar);
                    tbLugar.TabPages.Add(tpBuscarLugar);
                    MessageBox.Show(Mensaje);
                    cbLugares.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrEliminarLugar.Click += delegate
            {
                IrVentanaEliminarLugar_Event?.Invoke(this, EventArgs.Empty);
                if (PuedoEliminar)
                {

                    tbLugar.TabPages.Remove(tpBuscarLugar);
                    tbLugar.TabPages.Add(tpEliminarLugar);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }


            };
            btnCancelarLugar.Click += delegate
            {
                RegresarVentanaEliminarLugar_Event?.Invoke(this, EventArgs.Empty);
                tbLugar.TabPages.Remove(tpEliminarLugar);
                tbLugar.TabPages.Add(tpBuscarLugar);
            };
            // Ventana "Editar Marca" //
            btnIrEditarLugar.Click += delegate {
                IrVentanaEditarLugar_Event?.Invoke(this, EventArgs.Empty);
                tbLugar.TabPages.Remove(tpBuscarLugar);
                tbLugar.TabPages.Add(tpAgregarEditarLugar);
                tpAgregarEditarLugar.Text = "Editar Lugar";
                btnGuardarEditar.Text = "Editar";
            };
            // Ventana "Buscar Lugar" //
            btnBuscar.Click += delegate
            {
                BuscarLugar_Event?.Invoke(this, EventArgs.Empty);
            };
        }
        // /////// //
        // EVENTOS //
        // /////// //
        public event EventHandler AgregarNuevoLugar_Event;
        public event EventHandler IrVentanaAgregarNuevoLugar_Event;
        public event EventHandler RegresarVentanaAgregarNuevoLugar_Event;
        public event EventHandler EliminarLugar_Event;
        public event EventHandler IrVentanaEliminarLugar_Event;
        public event EventHandler RegresarVentanaEliminarLugar_Event;
        public event EventHandler EditarLugar_Event;
        public event EventHandler IrVentanaEditarLugar_Event;
        public event EventHandler RegresarVentanaEditarLugar_Event;
        public event EventHandler BuscarLugar_Event;




        // /////// //
        // METODOS //
        // /////// //

        // Aqui se muestran las marcas en una tabla al ver la primera pantalla
        public void EstablecerValoresBindingSource(BindingSource lugarLista)
        {
            dgLugar.DataSource = lugarLista;
        }


        // Aqui se muestran las marcas en una lista para que escojas cual reemplazara a la que quieres eliminar
        public void EstablecerValoresComboBox(IEnumerable<LugaresModel> lugarListaMenosLaQueVasAEliminar)
        {
            cbLugares.Items.Clear();
            foreach (var lugar in lugarListaMenosLaQueVasAEliminar)
            {
                cbLugares.Items.Add(lugar.NombreLugar);
            }
        }

        // PATRON SINGLETON, para que la ventana solo se invoke una vez y no existan duplicados
        public static LugaresView ObtenerLaVentanaLugares(Form ventanaPadre)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed)
            {
                // creamos la ventana
                instancia = new LugaresView();
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
