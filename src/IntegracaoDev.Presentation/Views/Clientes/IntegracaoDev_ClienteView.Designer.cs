using dpLibrary05;

namespace IntegracaoDev.Presentation.Views.Clientes
{
    partial class IntegracaoDev_ClienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntegracaoDev_ClienteView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.integracaoDev_PesquisaView1 = new IntegracaoDev.Presentation.Views.Pesquisa.IntegracaoDev_PesquisaView();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.tableLayoutPanel1);
            this.pnSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // tpSystemParameters
            // 
            this.tpSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.7733F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.2267F));
            this.tableLayoutPanel1.Controls.Add(this.integracaoDev_PesquisaView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 356);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // integracaoDev_PesquisaView1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.integracaoDev_PesquisaView1, 2);
            this.integracaoDev_PesquisaView1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.integracaoDev_PesquisaView1.DotNetContainer = false;
            this.integracaoDev_PesquisaView1.KeyPreview = false;
            this.integracaoDev_PesquisaView1.Location = new System.Drawing.Point(3, 3);
            this.integracaoDev_PesquisaView1.Name = "integracaoDev_PesquisaView1";
            this.integracaoDev_PesquisaView1.OpenModal = false;
            this.integracaoDev_PesquisaView1.Parameters = ((System.Collections.Generic.IDictionary<string, object>)(resources.GetObject("integracaoDev_PesquisaView1.Parameters")));
            this.integracaoDev_PesquisaView1.Size = new System.Drawing.Size(664, 109);
            this.integracaoDev_PesquisaView1.StartPositionControl = null;
            this.integracaoDev_PesquisaView1.TabIndex = 5;
            this.integracaoDev_PesquisaView1.TabOrderScheme = dpLibrary05.TabOrderManager.TabScheme.None;
            // 
            // IntegracaoDev_ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IntegracaoDev_ClienteView";
            this.Size = new System.Drawing.Size(800, 450);
            this.pnSystemParameters.ResumeLayout(false);
            this.tpSystemParameters.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1DockingTabPage dtpFiltros;
        private C1.Win.C1Command.C1DockingTabPage dtpReport;
        internal C1.Win.C1Input.C1SplitButton btnok;
        internal C1.Win.C1Input.C1SplitButton btnpreferencefilter;
        public FlexGroupControl fgcCliente;
        private System.Windows.Forms.ToolStripSplitButton sbPrincipal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Pesquisa.IntegracaoDev_PesquisaView integracaoDev_PesquisaView1;
    }
}