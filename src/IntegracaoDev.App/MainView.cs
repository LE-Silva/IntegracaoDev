using dpLibrary05;
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
        }
    }
}
