using cochinitoDeDulce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cochinitoDeDulce.Views
{
    public partial class MarcasView : Form,IMarcasView
    {
        // ///////// //
        // ATRIBUTOS //
        // ///////// //
        private bool estoyEditando;
        private bool fueExitoso;
        private bool puedoEliminar;
        private string mensaje;
        private static MarcasView instancia;// para el patron singleton

        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // Del modelo 
        public string IdMarca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreMarca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Solo en codigo
        public bool EstoyEditando { get => estoyEditando; set => estoyEditando = value; }
        public bool FueExitoso { get => fueExitoso; set => fueExitoso=value; }
        public bool PuedoEliminar { get => puedoEliminar; set => puedoEliminar = value; }
        public string Mensaje { get => mensaje; set => mensaje=value; }

        // De la vista
        public string TxtBuscarMarca { get => txtBuscarMarca.Text; set => txtBuscarMarca.Text = value; }
        public string TxtAgregarEditar { get => txtAgregarEditar.Text; set => txtAgregarEditar.Text = value; }
        public string LblAgregarEditar { get => lblAgregarEditar.Text; set => lblAgregarEditar.Text = value; }
        public string LblElimnarMarca { get => lblEliminarMarca.Text; set => lblEliminarMarca.Text = value; }
        public string CbEliminar { get => cbMarcas.Text; set => cbMarcas.Text=value; }

        public MarcasView()
        {
            InitializeComponent();
            // asocio los eventos
            AsociarEventosDeLaVistaMarca();
            // oculto las ventanas que no quiero que se vean al inicio
            tbMarca.TabPages.Remove(tpAgregarEditarMarca);
            tbMarca.TabPages.Remove(tpEliminarMarca);
        }

        private void AsociarEventosDeLaVistaMarca()
        {
            // Ventana "Agregar Marca" //
            btnGuardarEditar.Click += delegate
            {
                if (!EstoyEditando)
                {
                    AgregarNuevaMarca_Event?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    EditarMarca_Event?.Invoke(this, EventArgs.Empty);
                }

                if (FueExitoso)
                {
                    tbMarca.TabPages.Remove(tpAgregarEditarMarca);
                    tbMarca.TabPages.Add(tpBuscarMarca);
                    txtAgregarEditar.Text = "";
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrAgregarMarca.Click += delegate
            {
                IrVentanaAgregarNuevaMarca_Event?.Invoke(this, EventArgs.Empty);
                tbMarca.TabPages.Remove(tpBuscarMarca);
                tbMarca.TabPages.Add(tpAgregarEditarMarca);
                tpAgregarEditarMarca.Text = "Agregar marca";
                lblAgregarEditar.Text = "Ingrese el nombre de la nueva marca";
                btnGuardarEditar.Text = "Agregar";
            };
            btnRegresarEditarGuardar.Click += delegate
            {
                RegresarVentanaAgregarNuevaMarca_Event?.Invoke(this, EventArgs.Empty);
                tbMarca.TabPages.Remove(tpAgregarEditarMarca);
                tbMarca.TabPages.Add(tpBuscarMarca);
            };
            // Ventana "Eliminar Marca" //
            btnEliminarEliminar.Click += delegate
            {
                EliminarMarca_Event?.Invoke(this, EventArgs.Empty);
                if (FueExitoso)
                {
                    tbMarca.TabPages.Remove(tpEliminarMarca);
                    tbMarca.TabPages.Add(tpBuscarMarca);
                    MessageBox.Show(Mensaje);
                    cbMarcas.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };
            btnIrEliminarMarca.Click += delegate
            {
                IrVentanaEliminarMarca_Event?.Invoke(this, EventArgs.Empty);
                if (PuedoEliminar)
                {
                   
                    tbMarca.TabPages.Remove(tpBuscarMarca);
                    tbMarca.TabPages.Add(tpEliminarMarca);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }


            };
            btnCancelarEliminar.Click += delegate
            {
                RegresarVentanaEliminarMarca_Event?.Invoke(this, EventArgs.Empty);
                tbMarca.TabPages.Remove(tpEliminarMarca);
                tbMarca.TabPages.Add(tpBuscarMarca);
            };
            // Ventana "Editar Marca" //
            btnIrEditarMarca.Click += delegate{
                IrVentanaEditarMarca_Event?.Invoke(this, EventArgs.Empty);
                tbMarca.TabPages.Remove(tpBuscarMarca);
                tbMarca.TabPages.Add(tpAgregarEditarMarca);
                tpAgregarEditarMarca.Text = "Editar marca";
                btnGuardarEditar.Text = "Editar";
            };
            // Ventana "Buscar Marca" //
            btnBuscar.Click += delegate
            {
                BuscarMarca_Event?.Invoke(this, EventArgs.Empty);
            };
        }
        // /////// //
        // EVENTOS //
        // /////// //
        public event EventHandler AgregarNuevaMarca_Event;
        public event EventHandler IrVentanaAgregarNuevaMarca_Event;
        public event EventHandler RegresarVentanaAgregarNuevaMarca_Event;
        public event EventHandler EliminarMarca_Event;
        public event EventHandler IrVentanaEliminarMarca_Event;
        public event EventHandler RegresarVentanaEliminarMarca_Event;
        public event EventHandler EditarMarca_Event;
        public event EventHandler IrVentanaEditarMarca_Event;
        public event EventHandler RegresarVentanaEditarMarca_Event;
        public event EventHandler BuscarMarca_Event;




        // /////// //
        // METODOS //
        // /////// //

        // Aqui se muestran las marcas en una tabla al ver la primera pantalla
        public void EstablecerValoresBindingSource(BindingSource marcasLista)
        {
            dgMarcas.DataSource = marcasLista;
        }

    
        // Aqui se muestran las marcas en una lista para que escojas cual reemplazara a la que quieres eliminar
        public void EstablecerValoresComboBox(IEnumerable<MarcasModel> marcasListaMenosLaQueVasAEliminar)
        {
            cbMarcas.Items.Clear();
            foreach(var marca in marcasListaMenosLaQueVasAEliminar)
            {
                cbMarcas.Items.Add(marca.NombreMarca);
            }
        }

        // PATRON SINGLETON, para que la ventana solo se invoke una vez y no existan duplicados
        public static MarcasView ObtenerLaVentanaMarcas(Form ventanaPadre)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed)
            {
                // creamos la ventana
                instancia = new MarcasView();
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
 

        // funcion creda por accidente, de rato la elimino xddddd
        private void tbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
