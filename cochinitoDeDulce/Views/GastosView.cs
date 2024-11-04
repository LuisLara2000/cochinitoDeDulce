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
    public partial class GastosView : Form,IGastosView
    {
        // ///////// //
        // ATRIBUTOS //
        // ///////// //
        private bool estoyEditando;
        private bool fueExitoso;
        private bool puedoEliminar;
        private string mensaje;
        private static GastosView instancia;// para el patron singleton

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
        public string TxtBuscarGasto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // ------ [Solo en codigo] ----- //
        public bool EstoyEditando { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FueExitoso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Mensaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public GastosView()
        {
            InitializeComponent();
            // asociamos los eventos
        }

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

        // /////// //
        // METODOS //
        // /////// //

        private void AsociarEventosDeLaVistaGastos()
        {

        }

        // Para el data grid
        public void EstablecerCategoriasComboBox(IEnumerable<CategoriasModel> categoriasDisponibles)
        {
            throw new NotImplementedException();
        }

        // Para cada combo box que se muestra en la ventana de agregar/editar
        public void EstablecerLugaresComboBox(IEnumerable<LugaresModel> lugaresDisponibles)
        {
            throw new NotImplementedException();
        }

        public void EstablecerMarcasComboBox(IEnumerable<MarcasModel> marcasDisponibles)
        {
            throw new NotImplementedException();
        }

        public void EstablecerTiposComboBox(IEnumerable<TiposModel> tiposDisponibles)
        {
            throw new NotImplementedException();
        }

        public void EstablecerValoresBindingSource(BindingSource gastosLista)
        {
            dgGasto.DataSource = gastosLista;
        }

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
    }
}
