namespace IntegracaoDev.Presentation.Views.Pesquisa
{
    partial class IntegracaoDev_PesquisaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private dpLibrary05.Infrastructure.Controls.DPLookUpEdit luePesquisa;

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
            this.luePesquisa = new dpLibrary05.Infrastructure.Controls.DPLookUpEdit();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.cbTpPessoa = new System.Windows.Forms.ComboBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // luePesquisa
            // 
            this.luePesquisa.Active = false;
            this.luePesquisa.ControlHandlesSearchExecution = true;
            this.luePesquisa.DP_DataField = null;
            this.luePesquisa.DP_FilterMemo = false;
            this.luePesquisa.DP_SearchMethodFilter = null;
            this.luePesquisa.DP_ShowCaption = true;
            this.luePesquisa.FindMode = false;
            this.luePesquisa.InterfaceField = null;
            this.luePesquisa.IsReadonly = false;
            this.luePesquisa.Location = new System.Drawing.Point(15, 25);
            this.luePesquisa.Name = "luePesquisa";
            this.luePesquisa.SearchObject = null;
            this.luePesquisa.SettingValue = false;
            this.luePesquisa.Size = new System.Drawing.Size(422, 40);
            this.luePesquisa.TabIndex = 4;
            this.luePesquisa.Value = null;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // cbTpPessoa
            // 
            this.cbTpPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTpPessoa.FormattingEnabled = true;
            this.cbTpPessoa.Location = new System.Drawing.Point(457, 34);
            this.cbTpPessoa.Name = "cbTpPessoa";
            this.cbTpPessoa.Size = new System.Drawing.Size(121, 24);
            this.cbTpPessoa.TabIndex = 5;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(608, 38);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(50, 17);
            this.chkCliente.TabIndex = 6;
            this.chkCliente.Text = "Ativo";
            this.chkCliente.UseVisualStyleBackColor = true;
            // 
            // IntegracaoDev_PesquisaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTpPessoa);
            this.Controls.Add(this.chkCliente);
            this.Controls.Add(this.luePesquisa);
            this.Name = "IntegracaoDev_PesquisaView";
            this.Size = new System.Drawing.Size(664, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox cbTpPessoa;
        private System.Windows.Forms.CheckBox chkCliente;
    }
}