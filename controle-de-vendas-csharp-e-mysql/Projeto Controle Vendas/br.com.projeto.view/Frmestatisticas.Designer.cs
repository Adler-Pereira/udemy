namespace Projeto_Controle_Vendas.br.com.projeto.view
{
    partial class Frmestatisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartTotalGasto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTotalVendas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estatísticas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 92);
            this.panel1.TabIndex = 16;
            // 
            // chartTotalGasto
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalGasto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalGasto.Legends.Add(legend1);
            this.chartTotalGasto.Location = new System.Drawing.Point(46, 112);
            this.chartTotalGasto.Name = "chartTotalGasto";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Total Gasto";
            series1.Name = "TotalGasto";
            this.chartTotalGasto.Series.Add(series1);
            this.chartTotalGasto.Size = new System.Drawing.Size(410, 350);
            this.chartTotalGasto.TabIndex = 17;
            this.chartTotalGasto.Text = "chart1";
            // 
            // chartTotalVendas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTotalVendas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTotalVendas.Legends.Add(legend2);
            this.chartTotalVendas.Location = new System.Drawing.Point(479, 112);
            this.chartTotalVendas.Name = "chartTotalVendas";
            this.chartTotalVendas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Total de Vendas";
            series2.Name = "TotalVendas";
            this.chartTotalVendas.Series.Add(series2);
            this.chartTotalVendas.Size = new System.Drawing.Size(410, 350);
            this.chartTotalVendas.TabIndex = 18;
            this.chartTotalVendas.Text = "chart1";
            // 
            // Frmestatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.chartTotalVendas);
            this.Controls.Add(this.chartTotalGasto);
            this.Controls.Add(this.panel1);
            this.Name = "Frmestatisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Estatísticas";
            this.Load += new System.EventHandler(this.Frmestatisticas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalGasto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalVendas;
    }
}