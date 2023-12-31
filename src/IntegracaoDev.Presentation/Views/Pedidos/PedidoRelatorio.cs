﻿using dpLibrary05.Infrastructure.UserControls;
using System;

namespace IntegracaoDevApp.SubViews
{
    public partial class IntegracaoDevApp_RelatorioView : ucSymGen_ReportDialog
    {
        public IntegracaoDevApp_RelatorioView()
        {
            InitializeComponent();
            OnConfiguration();
        }

        private void OnConfiguration()
        {
            this.BeforeLoadReport += OnBeforeLoadReport;
            this.LoadReport += OnLoadReport;
            this.ReportConfiguration += OnReportConfiguration;
        }

        private void OnBeforeLoadReport(object sender, BeforeLoadReportEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNumPedido.Text))
                {
                    e.Cancel = true;
                    e.CancelControl = txtNumPedido;
                    e.CancelMessage = "Numero do Pedido é obrigatório";
                    return;
                }

                var feExibir = chkExibirItens.Checked.ToString();
                e.Parameter.Items.Add(nameof(feExibir), feExibir);

                var feNumPedido = txtNumPedido.Text;
                e.Parameter.Items.Add(nameof(feNumPedido), feNumPedido);
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.Message;
                e.Cancel = true;
                e.CancelReason = ReportStateEnum.Err;
                return;
            }
        }

        private void OnLoadReport(object sender, LoadReportEventArgs e)
        {
            try
            {
                string feExibir;
                feExibir = chkExibirItens.Checked.ToString();

                int feNumPedido;
                int.TryParse(txtNumPedido.Text, out feNumPedido);

                var report = ReportList[50000];

                //Parâmetros passado para o Designer do Report, exemplo algum componente
                report.Formulas.Items.Add("titulo", "Impressão");
                report.Formulas.Items.Add("feNumPedido", feNumPedido);
                report.Formulas.Items.Add("feExibir", feExibir);

                //Parâmetro passado ao datasource do Relatório
                report.Parametros.Items.Add("feNumPedido", feNumPedido);
                report.Parametros.Items.Add("feExibir", feExibir);

                e.ReportData = report;
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.Message;
                e.Cancel = true;
                e.CancelReason = ReportStateEnum.Err;
                return;
            }
        }

        private void OnReportConfiguration(object sender, ReportConfigurationEventArgs e)
        {
            e.ReportList.Add(50000,
                             new dpLibrary05.SymphonyReport.clsSymReport.ReportData(true)
                             {
                                 Id = 5000001,
                                 ItemSeg = 166.ToString(),
                                 Name = "Impressão do Pedido"
                             });
            e.SecurityIdList.Add(50000);
        }
    }
}
