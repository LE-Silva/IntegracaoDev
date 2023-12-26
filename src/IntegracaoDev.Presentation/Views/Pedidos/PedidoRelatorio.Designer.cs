namespace IntegracaoDevApp.SubViews
{
    partial class IntegracaoDevApp_RelatorioView
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
            this.chkExibirItens = new System.Windows.Forms.CheckBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.txtNumPedido);
            this.pnSystemParameters.Controls.Add(this.chkExibirItens);
            this.pnSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // tpSystemParameters
            // 
            this.tpSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // chkExibirItens
            // 
            this.chkExibirItens.AutoSize = true;
            this.chkExibirItens.Location = new System.Drawing.Point(31, 77);
            this.chkExibirItens.Name = "chkExibirItens";
            this.chkExibirItens.Size = new System.Drawing.Size(128, 17);
            this.chkExibirItens.TabIndex = 0;
            this.chkExibirItens.Text = "Exibir Itens do Pedido";
            this.chkExibirItens.UseVisualStyleBackColor = true;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPedido.Location = new System.Drawing.Point(31, 43);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(128, 26);
            this.txtNumPedido.TabIndex = 1;
            // 
            // IntegracaoDevApp_RelatorioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IntegracaoDevApp_RelatorioView";
            this.Size = new System.Drawing.Size(800, 450);
            this.pnSystemParameters.ResumeLayout(false);
            this.pnSystemParameters.PerformLayout();
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExibirItens;
        private System.Windows.Forms.TextBox txtNumPedido;
    }
}