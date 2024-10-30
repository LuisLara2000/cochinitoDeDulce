using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cochinitoDeDulce.Views
{
    public partial class CategoriasView : Form, ICategoriasView
    {
        public CategoriasView()
        {
            // no se que hace esto jaja
            InitializeComponent();
            // asociamos los eventos con las acciones que suceden en la vista
            AsociarEventosDeLaVista();
            tbCategorias.TabPages.Remove(tpCategoriasAgregarEditar);
            tbCategorias.TabPages.Remove(tpEliminar);

        }

        private void AsociarEventosDeLaVista()
        {
            // Ventana "Agregar Categoria" //
          
            btnIrAgregar.Click += delegate {  // ir a la ventana
                IrVentanaAgregarNuevaCategoria_Event?.Invoke(this, EventArgs.Empty);
                tpCategoriasAgregarEditar.Text = "Agregar categoria";
                tbCategorias.TabPages.Remove(tpCategoriasVer);
                tbCategorias.TabPages.Add(tpCategoriasAgregarEditar);
                
            };
           
            btnRegresar.Click += delegate { // regresar de categorias
                Regresar_Event?.Invoke(this, EventArgs.Empty);
                tbCategorias.TabPages.Remove(tpCategoriasAgregarEditar);
                tbCategorias.TabPages.Add(tpCategoriasVer);
            };
            
            btnGuardar.Click += delegate {// guardar nueva categoria
                AgregarNuevaCategoria_Event?.Invoke(this, EventArgs.Empty);
                txtNombreCategoria.Text = "";
            };
            // Ventana "Eliminar Categoria" //
            btnIrEliminar.Click += delegate
            {
                IrVentanaEliminarCategoria_Event?.Invoke(this, EventArgs.Empty);
                tbCategorias.TabPages.Remove(tpCategoriasVer);
                tbCategorias.TabPages.Add(tpEliminar);
            };
            btnEliminarCategoriaCancelar.Click += delegate
            {
                tbCategorias.TabPages.Remove(tpEliminar);
                tbCategorias.TabPages.Add(tpCategoriasVer);
                cbEliminarCategoria.SelectedItem = null;
            };
            btnEliminarCategoriaEliminar.Click += delegate
            {
                EliminarCategoria_Event?.Invoke(this, EventArgs.Empty);
                cbEliminarCategoria.SelectedItem = null;
                tbCategorias.TabPages.Remove(tpEliminar);
                tbCategorias.TabPages.Add(tpCategoriasVer);

            };
            // Ventana "Editar Categoria"
            btnIrEditar.Click += delegate
            {
                IrVentanaEditarCategoria_Event?.Invoke(this, EventArgs.Empty);
                tpCategoriasAgregarEditar.Text = "Editar categoria";
                tbCategorias.TabPages.Remove(tpCategoriasVer);
                tbCategorias.TabPages.Add(tpCategoriasAgregarEditar);
            };
            // Ventana "Buscar Categoria"
            btnBuscar.Click += delegate
            {
                BuscarCategorias_Event?.Invoke(this, EventArgs.Empty);
            };
        }

        // no se usa
        public string IdCategoria {
            get { return "xd"; }
            set { var xd = value; }
        }
        public string NombreCategorias {
            get { return txtNombreCategoria.Text.ToString(); }
            set { txtNombreCategoria.Text = value; }
        }

        public string BuscarCategoriaTxt{ 
            get { return txtBuscarCategoria.Text.ToString(); } 
            set { txtBuscarCategoria.Text = value; }
        }

        public string EditarAgregarLbl {
            get { return lblGuardarEditar.Text; }
            set { lblGuardarEditar.Text = value; }
        }

        public string ElimnarLbl
        {
            get { return lblElimimarCategoria.Text; }
            set { lblElimimarCategoria.Text = value; }
        }

        public string CatagoriaEliminarCb
        {
            get { return cbEliminarCategoria.SelectedItem.ToString(); }         
        }

        // Ventana "Agregar Categoria"
        public event EventHandler AgregarNuevaCategoria_Event;
        public event EventHandler IrVentanaAgregarNuevaCategoria_Event;
        public event EventHandler RegresarVentanaAgregarNuevaCategoria_Event;
        // Ventana "Eliminar Categoria"
        public event EventHandler EliminarCategoria_Event;
        public event EventHandler IrVentanaEliminarCategoria_Event;
        public event EventHandler RegresarVentanaEliminarCategoria_Event;
        // Ventana "Editar Categoria"
        public event EventHandler EditarCategoria_Event;
        public event EventHandler IrVentanaEditarCategoria_Event;
        public event EventHandler RegresarVentanaEditarCategoria_Event;
        // Ventana "Buscar Categoria" (Esta es la ventana que se muestra al presionar "Categorias" en la ventana principal)
        public event EventHandler BuscarCategorias_Event;

        // sera sustituido
        public event EventHandler Regresar_Event;

        




        // metodos
        public void SetPetListBindingSource(BindingSource categoriasLista)
        {
            // Establecesmoe el parametro lista de categorias en el datagrid
            dgCategorias.DataSource = categoriasLista;
        }
        public void SetComboBoxCategoriasEliminar(ComboBox cbCategorias)
        {
            // limpio los registros 
            cbEliminarCategoria.Items.Clear();
            // asigno los nuevos
            foreach(var i in cbCategorias.Items)
            {
                cbEliminarCategoria.Items.Add(i);
            }
           
        }

        // patron singleton //
        // declaramos un campo privado del mismo tipo de clase
        private static CategoriasView instancia;
        public static CategoriasView ObtenerInstancia(Form padreContenedor)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed) 
            {
                // creamos la ventana
                instancia = new CategoriasView();
                // hacemos que la ventana "categorias" este dentro de la ventana principal
                instancia.MdiParent = padreContenedor;
                // le quitamos los bordes
                instancia.FormBorderStyle = FormBorderStyle.None;
                // hacemos que ocupe todo el espacio
                instancia.Dock = DockStyle.Fill;
            }
            else
            {
                // en caso de que ya exista
                // lo desminimizamos en caso de que este minimiazdo
                if(instancia.WindowState == FormWindowState.Minimized)
                    instancia.WindowState = FormWindowState.Normal;
                // y lo traemos al frente
                instancia.BringToFront();
            }
            // regresamos la ventana
            return instancia;
        }











        // no hacen nada
        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
