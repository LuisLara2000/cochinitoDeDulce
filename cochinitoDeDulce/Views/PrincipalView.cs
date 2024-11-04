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
    public partial class PrincipalView : Form, IPrincipalView
    {
        public PrincipalView()
        {
            InitializeComponent();
            btnCategorias.Click += delegate
            {
                MostrarCategorias_Evento?.Invoke(this,EventArgs.Empty);
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
            btnGastos.Click += delegate
            {
                MostrarGastos_Evento?.Invoke(this, EventArgs.Empty);
            };
          
        }

        public event EventHandler MostrarCategorias_Evento;
        public event EventHandler MostrarMarcas_Evento;
        public event EventHandler MostrarLugares_Evento;
        public event EventHandler MostrarTipos_Evento;
        public event EventHandler MostrarGastos_Evento;
    }
}
