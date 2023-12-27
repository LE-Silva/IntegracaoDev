using dpLibrary05;
using dpLibrary05.Infrastructure.Helpers;
using dpLibrary05.SymphonyInterface;
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
using static dpLibrary05.Infrastructure.UserControls.ucSymGen_ToolDialog;

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
                {
                    luePesquisa.Focus();
                }
                var isActive = e.SearchObject.Fields[5].GetValue();
                if ((string)isActive == "Sim") chkCliente.Checked = true;

                var TpPessoa = e.SearchObject.Fields[3].GetValue();
                switch (TpPessoa)
                {
                    case "Masculino":
                        cbTpPessoa.Text = "Masculino";
                        break;
                    case "Feminino":
                        cbTpPessoa.Text = "Feminino";
                        break;
                    default:
                        cbTpPessoa.Text = "Juridico";
                    break;
                }
            };

            luePesquisa.SearchObject = searchMarca;
        }
    }
}
