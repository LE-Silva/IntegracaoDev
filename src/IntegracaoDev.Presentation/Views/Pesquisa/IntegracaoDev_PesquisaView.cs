using dpLibrary05;
using dpLibrary05.Infrastructure.Helpers;
using IntegracaoDev.Presentation.Common.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoDev.Presentation.Views.Pesquisa
{
    public partial class IntegracaoDev_PesquisaView : DPUserControl
    {
        public IntegracaoDev_PesquisaView()
        {
            InitializeComponent();
            SetSearchs();
        }

        private void SetSearchs()
        {
            var searchMarca = IntegracaoDevSearch.Find_Cliente(new clsSymSearch.SearchArgs { });
            searchMarca.SetaAzul = false;

            searchMarca.BeforeSearch += (object sender, dpLibrary05.SymphonyInterface.BeforeSearchEventArgs e) =>
            {
                e.SearchObject.Filter = "1=1";
            };

            searchMarca.AfterSearch += (object sender, dpLibrary05.SymphonyInterface.AfterSearchEventArgs e) =>
            {
                if (!e.result)
                    luePesquisa.Focus();
            };

            luePesquisa.SearchObject = searchMarca;
        }
    }
}
