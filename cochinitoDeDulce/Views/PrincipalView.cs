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
                MostrarCategorias?.Invoke(this,EventArgs.Empty);
            };
          
        }

        public event EventHandler MostrarCategorias;
    }
}
