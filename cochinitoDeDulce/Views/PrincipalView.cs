using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// importo estilos
using cochinitoDeDulce.Estilos;

namespace cochinitoDeDulce.Views
{
    public partial class PrincipalView : Form, IPrincipalView
    {
        private bool quieresSalirDeLaAplicacion;
        public PrincipalView()
        {

            InitializeComponent();

            // le da estilo a la forma
            Estilos.EstilosPrincipal.CargarEstilosPrincipal(this);
            /*
            btnCategorias.Click += delegate
            {
                MostrarCategorias_Evento?.Invoke(this, EventArgs.Empty);
            };
            btnMarcas.Click += delegate
            {
                MostrarMarcas_Evento?.Invoke(this, EventArgs.Empty);
            };
            btnLugares.Click += delegate
            {
                MostrarLugares_Evento?.Invoke(this, EventArgs.Empty);
            };
            btnTipos.Click += delegate
            {
                MostrarTipos_Evento?.Invoke(this, EventArgs.Empty);
            };
            */
            btnGastos.Click += delegate
            {
                MostrarGastos_Evento?.Invoke(this, EventArgs.Empty);
            };

            btnIngresos.Click += delegate
            {
                MostrarIngresos_Evento?.Invoke(this, EventArgs.Empty);
            };

            btnInicio.Click += delegate
            {
                MostrarInicio_Evento?.Invoke(this, EventArgs.Empty);
            };

            pbLogo.Click += delegate
            {
                CerrarAplicacion_Evento?.Invoke(this, EventArgs.Empty);
                if(QuieresSalirDeLaAplicacion)
                    Close();
            };

            btnParametros.Click += delegate
            {
                MostrarParametros_Evento?.Invoke(this, EventArgs.Empty);
            };
        }

        public bool QuieresSalirDeLaAplicacion { get => quieresSalirDeLaAplicacion; set => quieresSalirDeLaAplicacion=value; }
        /*
        public event EventHandler MostrarCategorias_Evento;
        public event EventHandler MostrarMarcas_Evento;
        public event EventHandler MostrarLugares_Evento;
        public event EventHandler MostrarTipos_Evento;
        */
        public event EventHandler MostrarGastos_Evento;
        public event EventHandler MostrarIngresos_Evento;
        public event EventHandler MostrarInicio_Evento;
        public event EventHandler CerrarAplicacion_Evento;
        public event EventHandler MostrarParametros_Evento;

        private void btnGastos_Click(object sender, EventArgs e)
        {

        }
    }
}
