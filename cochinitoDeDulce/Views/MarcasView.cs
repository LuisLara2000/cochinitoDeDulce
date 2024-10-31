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
    public partial class MarcasView : Form,IMarcasView
    {
        // ///////// //
        // ATRIBUTOS //
        // ///////// //
        private bool estoyEditando;
        private bool fueExitoso;
        private bool puedoEditar;
        private string mensaje;
        private static MarcasView instancia;// para el patron singleton

        // /////////// //
        // PROPIEDADES //
        // /////////// //
        public string IdMarca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NombreMarca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EstoyEditando { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FueExitoso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PuedoEliminar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Mensaje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MarcasView()
        {
            InitializeComponent();
        }

        // /////// //
        // EVENTOS //
        // /////// //
        public event EventHandler AgregarNuevaMarca_Event;
        public event EventHandler IrVentanaAgregarNuevaMarca_Event;
        public event EventHandler RegresarVentanaAgregarNuevaMarca_Event;
        public event EventHandler EliminarMarca_Event;
        public event EventHandler IrVentanaEliminarCMarca_Event;
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
            throw new NotImplementedException();
        }

    
        // Aqui se muestran las marcas en una lista para que escojas cual reemplazara a la que quieres eliminar
        public void EstablecerValoresComboBox(List<string> marcasListaMenosLaQueVasAEliminar)
        {
            throw new NotImplementedException();
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
