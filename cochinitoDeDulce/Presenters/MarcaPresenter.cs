using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// importo las vistas y modelos
using cochinitoDeDulce.Models;
using cochinitoDeDulce.Views;
namespace cochinitoDeDulce.Presenters
{
    public class MarcaPresenter
    {
        private IMarcasView iViewMarca;
        private IMarcasDataBase dataBaseMarca;
        private BindingSource marcasBindingsSource;
        private IEnumerable<MarcasModel> marcasList;
        private List<MarcasModel> listComboBox;

        public MarcaPresenter(IMarcasView viewM, IMarcasDataBase databaseM)
        {
            this.marcasBindingsSource = new BindingSource();
            this.listComboBox = new List<MarcasModel>();
            iViewMarca = viewM;
            dataBaseMarca = databaseM;
            // suscribimos los eventos
            // inicializamos el binding source y el combobox
            // cargo las marcas
            // muestro en pantalla 
            viewM.Show();
        }
    }
}
