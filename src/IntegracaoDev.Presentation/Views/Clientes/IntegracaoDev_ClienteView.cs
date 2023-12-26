using Dataplace.Core.Comunications;
using Dataplace.Core.win.Views.Controllers;
using dpLibrary05;
using dpLibrary05.Infrastructure.UserControls;
using IntegracaoDevApp.Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoDev.Presentation.Views.Clientes
{
    public partial class IntegracaoDev_ClienteView : ucSymGen_ReportDialog
    {
        private DataTable _dataTableClientes = new DataTable();
        private ClienteAppService _clienteAppService;
        public IntegracaoDev_ClienteView()
        {
            InitializeComponent();

            _clienteAppService = new ClienteAppService();
        }
    }
}
