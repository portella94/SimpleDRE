namespace SimpleDRE
{
    partial class MDIFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIFrm));
            this.lblConta = new System.Windows.Forms.Label();
            this.txtJaneiro = new System.Windows.Forms.MaskedTextBox();
            this.lblJaneiro = new System.Windows.Forms.Label();
            this.lblFevereiro = new System.Windows.Forms.Label();
            this.txtFevereiro = new System.Windows.Forms.MaskedTextBox();
            this.lblMarco = new System.Windows.Forms.Label();
            this.txtMarco = new System.Windows.Forms.MaskedTextBox();
            this.lblAbril = new System.Windows.Forms.Label();
            this.txtAbril = new System.Windows.Forms.MaskedTextBox();
            this.lblMaio = new System.Windows.Forms.Label();
            this.txtMaio = new System.Windows.Forms.MaskedTextBox();
            this.lblJunho = new System.Windows.Forms.Label();
            this.txtJunho = new System.Windows.Forms.MaskedTextBox();
            this.lblJulho = new System.Windows.Forms.Label();
            this.txtJulho = new System.Windows.Forms.MaskedTextBox();
            this.lblAgosto = new System.Windows.Forms.Label();
            this.txtAgosto = new System.Windows.Forms.MaskedTextBox();
            this.lblSetembro = new System.Windows.Forms.Label();
            this.txtSetembro = new System.Windows.Forms.MaskedTextBox();
            this.lblOutubro = new System.Windows.Forms.Label();
            this.txtOutubro = new System.Windows.Forms.MaskedTextBox();
            this.lblNovembro = new System.Windows.Forms.Label();
            this.txtNovembro = new System.Windows.Forms.MaskedTextBox();
            this.lblDezembro = new System.Windows.Forms.Label();
            this.txtDezembro = new System.Windows.Forms.MaskedTextBox();
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cmbContas = new System.Windows.Forms.ComboBox();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(9, 410);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(35, 13);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "Conta";
            // 
            // txtJaneiro
            // 
            this.txtJaneiro.Location = new System.Drawing.Point(145, 427);
            this.txtJaneiro.Mask = "00000.000";
            this.txtJaneiro.Name = "txtJaneiro";
            this.txtJaneiro.Size = new System.Drawing.Size(60, 20);
            this.txtJaneiro.TabIndex = 3;
            this.txtJaneiro.ValidatingType = typeof(int);
            this.txtJaneiro.Validating += new System.ComponentModel.CancelEventHandler(this.txtJaneiro_Validating);
            // 
            // lblJaneiro
            // 
            this.lblJaneiro.AutoSize = true;
            this.lblJaneiro.Location = new System.Drawing.Point(142, 411);
            this.lblJaneiro.Name = "lblJaneiro";
            this.lblJaneiro.Size = new System.Drawing.Size(41, 13);
            this.lblJaneiro.TabIndex = 4;
            this.lblJaneiro.Text = "Janeiro";
            // 
            // lblFevereiro
            // 
            this.lblFevereiro.AutoSize = true;
            this.lblFevereiro.Location = new System.Drawing.Point(209, 411);
            this.lblFevereiro.Name = "lblFevereiro";
            this.lblFevereiro.Size = new System.Drawing.Size(51, 13);
            this.lblFevereiro.TabIndex = 6;
            this.lblFevereiro.Text = "Fevereiro";
            // 
            // txtFevereiro
            // 
            this.txtFevereiro.Location = new System.Drawing.Point(212, 427);
            this.txtFevereiro.Mask = "00000.000";
            this.txtFevereiro.Name = "txtFevereiro";
            this.txtFevereiro.Size = new System.Drawing.Size(60, 20);
            this.txtFevereiro.TabIndex = 5;
            this.txtFevereiro.Validating += new System.ComponentModel.CancelEventHandler(this.txtFevereiro_Validating);
            // 
            // lblMarco
            // 
            this.lblMarco.AutoSize = true;
            this.lblMarco.Location = new System.Drawing.Point(275, 411);
            this.lblMarco.Name = "lblMarco";
            this.lblMarco.Size = new System.Drawing.Size(37, 13);
            this.lblMarco.TabIndex = 8;
            this.lblMarco.Text = "Março";
            // 
            // txtMarco
            // 
            this.txtMarco.Location = new System.Drawing.Point(278, 427);
            this.txtMarco.Mask = "00000.000";
            this.txtMarco.Name = "txtMarco";
            this.txtMarco.Size = new System.Drawing.Size(60, 20);
            this.txtMarco.TabIndex = 7;
            this.txtMarco.Validating += new System.ComponentModel.CancelEventHandler(this.txtMarco_Validating);
            // 
            // lblAbril
            // 
            this.lblAbril.AutoSize = true;
            this.lblAbril.Location = new System.Drawing.Point(341, 411);
            this.lblAbril.Name = "lblAbril";
            this.lblAbril.Size = new System.Drawing.Size(27, 13);
            this.lblAbril.TabIndex = 10;
            this.lblAbril.Text = "Abril";
            // 
            // txtAbril
            // 
            this.txtAbril.Location = new System.Drawing.Point(344, 427);
            this.txtAbril.Mask = "00000.000";
            this.txtAbril.Name = "txtAbril";
            this.txtAbril.Size = new System.Drawing.Size(60, 20);
            this.txtAbril.TabIndex = 9;
            this.txtAbril.Validating += new System.ComponentModel.CancelEventHandler(this.txtAbril_Validating);
            // 
            // lblMaio
            // 
            this.lblMaio.AutoSize = true;
            this.lblMaio.Location = new System.Drawing.Point(407, 411);
            this.lblMaio.Name = "lblMaio";
            this.lblMaio.Size = new System.Drawing.Size(30, 13);
            this.lblMaio.TabIndex = 12;
            this.lblMaio.Text = "Maio";
            // 
            // txtMaio
            // 
            this.txtMaio.Location = new System.Drawing.Point(410, 427);
            this.txtMaio.Mask = "00000.000";
            this.txtMaio.Name = "txtMaio";
            this.txtMaio.Size = new System.Drawing.Size(60, 20);
            this.txtMaio.TabIndex = 11;
            this.txtMaio.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaio_Validating);
            // 
            // lblJunho
            // 
            this.lblJunho.AutoSize = true;
            this.lblJunho.Location = new System.Drawing.Point(473, 411);
            this.lblJunho.Name = "lblJunho";
            this.lblJunho.Size = new System.Drawing.Size(36, 13);
            this.lblJunho.TabIndex = 14;
            this.lblJunho.Text = "Junho";
            // 
            // txtJunho
            // 
            this.txtJunho.Location = new System.Drawing.Point(476, 427);
            this.txtJunho.Mask = "00000.000";
            this.txtJunho.Name = "txtJunho";
            this.txtJunho.Size = new System.Drawing.Size(60, 20);
            this.txtJunho.TabIndex = 13;
            this.txtJunho.Validating += new System.ComponentModel.CancelEventHandler(this.txtJunho_Validating);
            // 
            // lblJulho
            // 
            this.lblJulho.AutoSize = true;
            this.lblJulho.Location = new System.Drawing.Point(539, 411);
            this.lblJulho.Name = "lblJulho";
            this.lblJulho.Size = new System.Drawing.Size(32, 13);
            this.lblJulho.TabIndex = 16;
            this.lblJulho.Text = "Julho";
            // 
            // txtJulho
            // 
            this.txtJulho.Location = new System.Drawing.Point(542, 427);
            this.txtJulho.Mask = "00000.000";
            this.txtJulho.Name = "txtJulho";
            this.txtJulho.Size = new System.Drawing.Size(60, 20);
            this.txtJulho.TabIndex = 15;
            this.txtJulho.Validating += new System.ComponentModel.CancelEventHandler(this.txtJulho_Validating);
            // 
            // lblAgosto
            // 
            this.lblAgosto.AutoSize = true;
            this.lblAgosto.Location = new System.Drawing.Point(605, 411);
            this.lblAgosto.Name = "lblAgosto";
            this.lblAgosto.Size = new System.Drawing.Size(40, 13);
            this.lblAgosto.TabIndex = 18;
            this.lblAgosto.Text = "Agosto";
            // 
            // txtAgosto
            // 
            this.txtAgosto.Location = new System.Drawing.Point(608, 427);
            this.txtAgosto.Mask = "00000.000";
            this.txtAgosto.Name = "txtAgosto";
            this.txtAgosto.Size = new System.Drawing.Size(60, 20);
            this.txtAgosto.TabIndex = 17;
            this.txtAgosto.Validating += new System.ComponentModel.CancelEventHandler(this.txtAgosto_Validating);
            // 
            // lblSetembro
            // 
            this.lblSetembro.AutoSize = true;
            this.lblSetembro.Location = new System.Drawing.Point(671, 411);
            this.lblSetembro.Name = "lblSetembro";
            this.lblSetembro.Size = new System.Drawing.Size(52, 13);
            this.lblSetembro.TabIndex = 20;
            this.lblSetembro.Text = "Setembro";
            // 
            // txtSetembro
            // 
            this.txtSetembro.Location = new System.Drawing.Point(674, 427);
            this.txtSetembro.Mask = "00000.000";
            this.txtSetembro.Name = "txtSetembro";
            this.txtSetembro.Size = new System.Drawing.Size(60, 20);
            this.txtSetembro.TabIndex = 19;
            this.txtSetembro.Validating += new System.ComponentModel.CancelEventHandler(this.txtSetembro_Validating);
            // 
            // lblOutubro
            // 
            this.lblOutubro.AutoSize = true;
            this.lblOutubro.Location = new System.Drawing.Point(737, 411);
            this.lblOutubro.Name = "lblOutubro";
            this.lblOutubro.Size = new System.Drawing.Size(45, 13);
            this.lblOutubro.TabIndex = 22;
            this.lblOutubro.Text = "Outubro";
            // 
            // txtOutubro
            // 
            this.txtOutubro.Location = new System.Drawing.Point(740, 427);
            this.txtOutubro.Mask = "00000.000";
            this.txtOutubro.Name = "txtOutubro";
            this.txtOutubro.Size = new System.Drawing.Size(60, 20);
            this.txtOutubro.TabIndex = 21;
            this.txtOutubro.Validating += new System.ComponentModel.CancelEventHandler(this.txtOutubro_Validating);
            // 
            // lblNovembro
            // 
            this.lblNovembro.AutoSize = true;
            this.lblNovembro.Location = new System.Drawing.Point(803, 411);
            this.lblNovembro.Name = "lblNovembro";
            this.lblNovembro.Size = new System.Drawing.Size(56, 13);
            this.lblNovembro.TabIndex = 24;
            this.lblNovembro.Text = "Novembro";
            // 
            // txtNovembro
            // 
            this.txtNovembro.Location = new System.Drawing.Point(806, 427);
            this.txtNovembro.Mask = "00000.000";
            this.txtNovembro.Name = "txtNovembro";
            this.txtNovembro.Size = new System.Drawing.Size(60, 20);
            this.txtNovembro.TabIndex = 23;
            this.txtNovembro.Validating += new System.ComponentModel.CancelEventHandler(this.txtNovembro_Validating);
            // 
            // lblDezembro
            // 
            this.lblDezembro.AutoSize = true;
            this.lblDezembro.Location = new System.Drawing.Point(869, 411);
            this.lblDezembro.Name = "lblDezembro";
            this.lblDezembro.Size = new System.Drawing.Size(55, 13);
            this.lblDezembro.TabIndex = 26;
            this.lblDezembro.Text = "Dezembro";
            // 
            // txtDezembro
            // 
            this.txtDezembro.Location = new System.Drawing.Point(872, 427);
            this.txtDezembro.Mask = "00000.000";
            this.txtDezembro.Name = "txtDezembro";
            this.txtDezembro.Size = new System.Drawing.Size(60, 20);
            this.txtDezembro.TabIndex = 25;
            this.txtDezembro.Validating += new System.ComponentModel.CancelEventHandler(this.txtDezembro_Validating);
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
            this.lstDRE.Size = new System.Drawing.Size(920, 395);
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
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(620, 466);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(103, 23);
            this.btnInserir.TabIndex = 28;
            this.btnInserir.Text = "Inserir na tabela";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(849, 466);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(83, 23);
            this.btnGerar.TabIndex = 29;
            this.btnGerar.Text = "Gerar relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(729, 466);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(114, 23);
            this.btnRemover.TabIndex = 30;
            this.btnRemover.Text = "Remover da tabela";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cmbContas
            // 
            this.cmbContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContas.FormattingEnabled = true;
            this.cmbContas.Location = new System.Drawing.Point(12, 427);
            this.cmbContas.Name = "cmbContas";
            this.cmbContas.Size = new System.Drawing.Size(127, 21);
            this.cmbContas.TabIndex = 2;
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(12, 454);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(127, 23);
            this.btnConta.TabIndex = 31;
            this.btnConta.Text = "Adicionar Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(527, 466);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // MDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.cmbContas);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lstDRE);
            this.Controls.Add(this.lblDezembro);
            this.Controls.Add(this.txtDezembro);
            this.Controls.Add(this.lblNovembro);
            this.Controls.Add(this.txtNovembro);
            this.Controls.Add(this.lblOutubro);
            this.Controls.Add(this.txtOutubro);
            this.Controls.Add(this.lblSetembro);
            this.Controls.Add(this.txtSetembro);
            this.Controls.Add(this.lblAgosto);
            this.Controls.Add(this.txtAgosto);
            this.Controls.Add(this.lblJulho);
            this.Controls.Add(this.txtJulho);
            this.Controls.Add(this.lblJunho);
            this.Controls.Add(this.txtJunho);
            this.Controls.Add(this.lblMaio);
            this.Controls.Add(this.txtMaio);
            this.Controls.Add(this.lblAbril);
            this.Controls.Add(this.txtAbril);
            this.Controls.Add(this.lblMarco);
            this.Controls.Add(this.txtMarco);
            this.Controls.Add(this.lblFevereiro);
            this.Controls.Add(this.txtFevereiro);
            this.Controls.Add(this.lblJaneiro);
            this.Controls.Add(this.txtJaneiro);
            this.Controls.Add(this.lblConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MDIFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleDRE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.MaskedTextBox txtJaneiro;
        private System.Windows.Forms.Label lblJaneiro;
        private System.Windows.Forms.Label lblFevereiro;
        private System.Windows.Forms.MaskedTextBox txtFevereiro;
        private System.Windows.Forms.Label lblMarco;
        private System.Windows.Forms.MaskedTextBox txtMarco;
        private System.Windows.Forms.Label lblAbril;
        private System.Windows.Forms.MaskedTextBox txtAbril;
        private System.Windows.Forms.Label lblMaio;
        private System.Windows.Forms.MaskedTextBox txtMaio;
        private System.Windows.Forms.Label lblJunho;
        private System.Windows.Forms.MaskedTextBox txtJunho;
        private System.Windows.Forms.Label lblJulho;
        private System.Windows.Forms.MaskedTextBox txtJulho;
        private System.Windows.Forms.Label lblAgosto;
        private System.Windows.Forms.MaskedTextBox txtAgosto;
        private System.Windows.Forms.Label lblSetembro;
        private System.Windows.Forms.MaskedTextBox txtSetembro;
        private System.Windows.Forms.Label lblOutubro;
        private System.Windows.Forms.MaskedTextBox txtOutubro;
        private System.Windows.Forms.Label lblNovembro;
        private System.Windows.Forms.MaskedTextBox txtNovembro;
        private System.Windows.Forms.Label lblDezembro;
        private System.Windows.Forms.MaskedTextBox txtDezembro;
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
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox cmbContas;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnLimpar;
    }
}

