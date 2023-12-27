using dpLibrary05;
using IntegracaoDev.Presentation.Views.Clientes;
using IntegracaoDevApp;
using IntegracaoDevApp.SubViews;
using IntegracaoDevApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoDev.App
{
    public partial class MainView : fMNU_Principal
    {
        public MainView()
        {
            InitializeComponent();

            this.Shown += (object sender, EventArgs e) =>
            {
                this.Text = "Integração Dev";
            };

            LoadMenu();
        }

        private void LoadMenu()
        {
            AddMenu(new ToolStripMenuItem("Cliente", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<ClienteWindow>(captionForm: "Clientes");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Cliente Novo", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoDev_ClienteView>(captionForm: "Clientes");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Produtos", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<ProdutoWindow>(captionForm: "Clientes");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Pedido", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<PedidoView>(captionForm: "Clientes");
            }), TipoMenuEnun.Arquivo);

            AddMenu(new ToolStripMenuItem("Pesquisas", null, (object sender, EventArgs e) =>
            {
                Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoDev_ClienteView>(captionForm: "Pesquisa");
            }), TipoMenuEnun.Arquivo);
        }
    }
}
