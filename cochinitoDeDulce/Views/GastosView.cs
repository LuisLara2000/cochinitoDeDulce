using cochinitoDeDulce.Models;
using cochinitoDeDulce.Presenters;
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
using cochinitoDeDulce.Estilos;

namespace cochinitoDeDulce.Views
{
    public partial class GastosView : Form, IGastosView
    {
        // ///////// //
        // ATRIBUTOS //
        // ///////// //
        private bool estoyEditando;
        private bool fueExitoso;
        private bool puedoEliminar;
        private string mensaje;
        private static GastosView instancia;// para el patron singleton
        private bool suscrito;
        // /////////// //
        // PROPIEDADES //
        // /////////// //

        // ------ [Del modelo ] ----- //
        public int IdGasto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Descuento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Cantidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Unidad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Fecha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Comentario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Categoria { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lugar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // ------ [De la vista] ----- //
        public string TxtBuscarGasto { get => txtBuscarGasto.Text; set => txtBuscarGasto.Text = value; }
        public string TxtAgregarEditar { get => txtAgregarEditar.Text; set => txtAgregarEditar.Text = value; }
        public string TxtPrecio { get => txtPrecio.Text; set => txtPrecio.Text = value; }
        public string TxtCantidad { get => txtCantidad.Text; set => txtCantidad.Text = value; }
        public string TxtDescuento { get => txtDescuento.Text; set => txtDescuento.Text = value; }
        public string TxtComentario { get => txtComentario.Text; set => txtComentario.Text = value; }
        // ------ [Solo en codigo] ----- //
        public bool EstoyEditando { get => estoyEditando; set => estoyEditando = value; }
        public bool FueExitoso { get => fueExitoso; set => fueExitoso = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string CbUnidad { get => cbUnidades.Text; set => cbUnidades.Text = value; }
        public string CbCategoria { get => cbCategorias.Text; set => cbCategorias.Text = value; }
        public string CbMarca { get => cbMarcas.Text; set => cbMarcas.Text = value; }
        public string CbLugar { get => cbLugares.Text; set => cbLugares.Text = value; }
        public string CbTipo { get => cbTipos.Text; set => cbTipos.Text = value; }
        public bool Suscrito { get => suscrito; set => suscrito = value; }


        // /////// //
        // EVENTOS //
        // /////// //

        // ------ [Ventana "Buscar Gasto"] ----- //
        public event EventHandler BuscarGasto_Event;
        // ------ [Ventana "Agregar Gasto"] ----- //
        public event EventHandler AgregarNuevoGasto_Event;
        public event EventHandler IrVentanaAgregarNuevoGasto_Event;
        public event EventHandler RegresarVentanaAgregarNuevoGasto_Event;
        // ------ [Ventana "Editar Gasto"] ----- //
        public event EventHandler EditarGasto_Event;
        public event EventHandler IrVentanaEditarGasto_Event;
        // ------ [Ventana "Eliminar Gasto"] ----- //
        public event EventHandler EliminarGasto_Event;

        public GastosView()
        {
            InitializeComponent();
            Estilos.EstilosGeneral.CargarEstilosGeneral(this);
            Estilos.TamañosPosiciones.CargarPosiciones(this);
            // asociamos los eventos
            AsociarEventosDeLaVistaGastos();
            tbGasto.TabPages.Remove(tpAgregarEditarGasto);
        }
        // /////// //
        // METODOS //
        // /////// //

        private void AsociarEventosDeLaVistaGastos()
        {
            btnIrAgregarGasto.Click += delegate
            {
                IrVentanaAgregarNuevoGasto_Event?.Invoke(this, EventArgs.Empty);
                tbGasto.TabPages.Remove(tpBuscarGasto);
                tbGasto.TabPages.Add(tpAgregarEditarGasto);
                btnGuardarEditar.Text = "Agregar";

            };
            btnRegresarEditarGuardar.Click += delegate
            {
                RegresarVentanaAgregarNuevoGasto_Event?.Invoke(this, EventArgs.Empty);
                tbGasto.TabPages.Remove(tpAgregarEditarGasto);
                tbGasto.TabPages.Add(tpBuscarGasto);
            };
            btnGuardarEditar.Click += delegate
            {
                if (EstoyEditando)
                {
                    EditarGasto_Event?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    AgregarNuevoGasto_Event?.Invoke(this, EventArgs.Empty);
                }

                if (FueExitoso)
                {
                    tbGasto.TabPages.Remove(tpAgregarEditarGasto);
                    tbGasto.TabPages.Add(tpBuscarGasto);
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    MessageBox.Show(Mensaje);
                }
            };

            btnIrEditarGasto.Click += delegate
            {
                IrVentanaEditarGasto_Event?.Invoke(this, EventArgs.Empty);
                tbGasto.TabPages.Remove(tpBuscarGasto);
                tbGasto.TabPages.Add(tpAgregarEditarGasto);
                btnGuardarEditar.Text = "Editar";
            };

            btnEliminarGasto.Click += delegate
            {
                EliminarGasto_Event?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Mensaje);
            };

            btnBuscar.Click += delegate
            {
                BuscarGasto_Event?.Invoke(this, EventArgs.Empty);
            };
        }

        // Para el data grid
        public void EstablecerCategoriasComboBox(IEnumerable<CategoriasModel> categoriasDisponibles)
        {
            cbCategorias.Items.Clear();
            foreach (var categorias in categoriasDisponibles)
            {
                cbCategorias.Items.Add(categorias.NombreCategoria);

            }
        }

        // Para cada combo box que se muestra en la ventana de agregar/editar
        public void EstablecerLugaresComboBox(IEnumerable<LugaresModel> lugaresDisponibles)
        {
            cbLugares.Items.Clear();
            foreach (var lugares in lugaresDisponibles)
            {
                cbLugares.Items.Add(lugares.NombreLugar);

            }
        }

        public void EstablecerMarcasComboBox(IEnumerable<MarcasModel> marcasDisponibles)
        {
            cbMarcas.Items.Clear();
            foreach (var marcas in marcasDisponibles)
            {
                cbMarcas.Items.Add(marcas.NombreMarca);

            }
        }

        public void EstablecerTiposComboBox(IEnumerable<TiposModel> tiposDisponibles)
        {
            cbTipos.Items.Clear();
            foreach (var tipos in tiposDisponibles)
            {
                cbTipos.Items.Add(tipos.NombreTipo);

            }
        }
        public void EstablecerUnidadesComboBox(List<string> listaUnidades)
        {
            cbUnidades.Items.Clear();
            foreach (var unidad in listaUnidades)
            {
                cbUnidades.Items.Add(unidad);

            }

        }




        public void EstablecerValoresBindingSource(BindingSource gastosLista)
        {
            dgGasto.DataSource = gastosLista;
        }
        // singleton
        public static GastosView ObtenerLaVentanaGastos(Form ventanaPadre)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed)
            {
                // creamos la ventana
                instancia = new GastosView();
                // hacemos que la ventana "categorias" este dentro de la ventana principal
                instancia.MdiParent = ventanaPadre;
                // le quitamos los bordes
                instancia.FormBorderStyle = FormBorderStyle.None;
                // hacemos que ocupe todo el espacio
                instancia.Dock = DockStyle.Fill;
                // 

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






        //-- borraaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaar
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarGasto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
