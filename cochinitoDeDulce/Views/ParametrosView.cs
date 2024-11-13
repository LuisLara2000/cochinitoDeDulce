using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cochinitoDeDulce.Estilos;

namespace cochinitoDeDulce.Views
{
    public partial class ParametrosView : Form,IParametrosView
    {
        private static ParametrosView instancia;
        private bool suscrito;
        public bool Suscrito { get => suscrito; set => suscrito = value; }
        public event EventHandler MostrarCategorias_Event;
        public event EventHandler MostrarLugares_Event;
        public event EventHandler MostrarTipos_Event;
        public event EventHandler MostrarMarcas_Event;

        public ParametrosView()
        {
            InitializeComponent();
            EstilosGeneral.CargarEstilosGeneral(this);
            SuscribirEventos();
        }

        void SuscribirEventos()
        {
            btnCategorias.Click += delegate
            {
                MostrarCategorias_Event?.Invoke(this, EventArgs.Empty);
            };
            btnLugares.Click += delegate
            {
                MostrarLugares_Event?.Invoke(this, EventArgs.Empty);
            };
            btnTipos.Click += delegate
            {
                MostrarTipos_Event?.Invoke(this, EventArgs.Empty);
            };
            btnMarcas.Click += delegate
            {
                MostrarMarcas_Event?.Invoke(this, EventArgs.Empty);
            };
        }

      

        

        public static ParametrosView ObtenerLaVentanaParametros(Form ventanaPadre)
        {
            // si la ventana no existe o fue eliminada
            if (instancia == null || instancia.IsDisposed)
            {
                // creamos la ventana
                instancia = new ParametrosView();
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
