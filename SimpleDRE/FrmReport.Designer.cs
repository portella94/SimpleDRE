namespace SimpleDRE
{
    partial class FrmReport
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
            this.lstDRE = new System.Windows.Forms.ListView();
            this.clConta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clJaneiro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFevereiro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMarco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAbril = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clJunho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clJulho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAgosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSetembro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clOutubro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNovembro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDezembro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDRE
            // 
            this.lstDRE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clConta,
            this.clJaneiro,
            this.clFevereiro,
            this.clMarco,
            this.clAbril,
            this.clMaio,
            this.clJunho,
            this.clJulho,
            this.clAgosto,
            this.clSetembro,
            this.clOutubro,
            this.clNovembro,
            this.clDezembro});
            this.lstDRE.GridLines = true;
            this.lstDRE.HideSelection = false;
            this.lstDRE.LabelWrap = false;
            this.lstDRE.Location = new System.Drawing.Point(12, 12);
            this.lstDRE.MultiSelect = false;
            this.lstDRE.Name = "lstDRE";
            this.lstDRE.Size = new System.Drawing.Size(920, 448);
            this.lstDRE.TabIndex = 0;
            this.lstDRE.UseCompatibleStateImageBehavior = false;
            this.lstDRE.View = System.Windows.Forms.View.Details;
            // 
            // clConta
            // 
            this.clConta.Text = "Conta";
            this.clConta.Width = 195;
            // 
            // clJaneiro
            // 
            this.clJaneiro.Text = "Janeiro";
            // 
            // clFevereiro
            // 
            this.clFevereiro.Text = "Fevereiro";
            // 
            // clMarco
            // 
            this.clMarco.Text = "Março";
            // 
            // clAbril
            // 
            this.clAbril.Text = "Abril";
            // 
            // clMaio
            // 
            this.clMaio.Text = "Maio";
            // 
            // clJunho
            // 
            this.clJunho.Text = "Junho";
            // 
            // clJulho
            // 
            this.clJulho.Text = "Julho";
            // 
            // clAgosto
            // 
            this.clAgosto.Text = "Agosto";
            // 
            // clSetembro
            // 
            this.clSetembro.Text = "Setembro";
            // 
            // clOutubro
            // 
            this.clOutubro.Text = "Outubro";
            // 
            // clNovembro
            // 
            this.clNovembro.Text = "Novembro";
            // 
            // clDezembro
            // 
            this.clDezembro.Text = "Dezembro";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(839, 466);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 23);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir relatório";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lstDRE);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstDRE;
        private System.Windows.Forms.ColumnHeader clConta;
        private System.Windows.Forms.ColumnHeader clJaneiro;
        private System.Windows.Forms.ColumnHeader clFevereiro;
        private System.Windows.Forms.ColumnHeader clMarco;
        private System.Windows.Forms.ColumnHeader clAbril;
        private System.Windows.Forms.ColumnHeader clMaio;
        private System.Windows.Forms.ColumnHeader clJunho;
        private System.Windows.Forms.ColumnHeader clJulho;
        private System.Windows.Forms.ColumnHeader clAgosto;
        private System.Windows.Forms.ColumnHeader clSetembro;
        private System.Windows.Forms.ColumnHeader clOutubro;
        private System.Windows.Forms.ColumnHeader clNovembro;
        private System.Windows.Forms.ColumnHeader clDezembro;
        private System.Windows.Forms.Button btnImprimir;
    }
}

