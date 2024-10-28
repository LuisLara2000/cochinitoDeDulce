﻿using System;
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
            // Ventana "Agregar Categoria"
            btnAgregar.Click += delegate {
                tbCategorias.TabPages.Remove(tpCategoriasVer);
                tbCategorias.TabPages.Add(tpCategoriasAgregarEditar);
            };

            btnRegresar.Click += delegate {
                Regresar_Event?.Invoke(this, EventArgs.Empty);
                tbCategorias.TabPages.Remove(tpCategoriasAgregarEditar);
                tbCategorias.TabPages.Add(tpCategoriasVer);
            };

            btnGuardar.Click += delegate {
                AgregarNuevaCategoria_Event?.Invoke(this, EventArgs.Empty);
                txtNombreCategoria.Text = "";
            };
            // Ventana "Eliminar Categoria"
            btnEliminar.Click += delegate
            {
                tbCategorias.TabPages.Remove(tpCategoriasVer);
                tbCategorias.TabPages.Add(tpEliminar);
            };
            // Ventana "Editar Categoria"
            // Ventana "Buscar Categoria"
            btnBuscar.Click += delegate
            {
                BuscarCategorias_Event?.Invoke(this, EventArgs.Empty);
            };
        }

        public string IdCategoria {
            get { return txtIdCategoria.Text.ToString(); }
            set { txtIdCategoria.Text = value; }
        }
        public string NombreCategorias {
            get { return txtNombreCategoria.Text.ToString(); }
            set { txtNombreCategoria.Text = value; }
        }

        public string BuscarCategoriaTxt{ 
            get { return txtBuscarCategoria.Text.ToString(); } 
            set { txtBuscarCategoria.Text = value; }
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
