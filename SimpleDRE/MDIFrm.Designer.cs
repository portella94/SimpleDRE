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
            this.lblConta = new System.Windows.Forms.Label();
            this.txtJaneiro = new System.Windows.Forms.MaskedTextBox();
            this.lblJaneiro = new System.Windows.Forms.Label();
            this.lblFevereiro = new System.Windows.Forms.Label();
            this.txtFevereiro = new System.Windows.Forms.MaskedTextBox();
            this.lblMarco = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblAbril = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.lblMaio = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.lblJunho = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.lblJulho = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.lblAgosto = new System.Windows.Forms.Label();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.lblSetembro = new System.Windows.Forms.Label();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.lblOutubro = new System.Windows.Forms.Label();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.lblNovembro = new System.Windows.Forms.Label();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.lblDezembro = new System.Windows.Forms.Label();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
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
            this.txtJaneiro.Mask = "00000,000";
            this.txtJaneiro.Name = "txtJaneiro";
            this.txtJaneiro.Size = new System.Drawing.Size(60, 20);
            this.txtJaneiro.TabIndex = 3;
            this.txtJaneiro.ValidatingType = typeof(int);
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
            this.txtFevereiro.Mask = "00000,000";
            this.txtFevereiro.Name = "txtFevereiro";
            this.txtFevereiro.Size = new System.Drawing.Size(60, 20);
            this.txtFevereiro.TabIndex = 5;
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
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(278, 427);
            this.maskedTextBox2.Mask = "00000,000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox2.TabIndex = 7;
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
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(344, 427);
            this.maskedTextBox3.Mask = "00000,000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox3.TabIndex = 9;
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
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(410, 427);
            this.maskedTextBox4.Mask = "00000,000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox4.TabIndex = 11;
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
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(476, 427);
            this.maskedTextBox5.Mask = "00000,000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox5.TabIndex = 13;
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
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(542, 427);
            this.maskedTextBox6.Mask = "00000,000";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox6.TabIndex = 15;
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
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(608, 427);
            this.maskedTextBox7.Mask = "00000,000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox7.TabIndex = 17;
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
            // maskedTextBox8
            // 
            this.maskedTextBox8.Location = new System.Drawing.Point(674, 427);
            this.maskedTextBox8.Mask = "00000,000";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox8.TabIndex = 19;
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
            // maskedTextBox9
            // 
            this.maskedTextBox9.Location = new System.Drawing.Point(740, 427);
            this.maskedTextBox9.Mask = "00000,000";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox9.TabIndex = 21;
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
            // maskedTextBox10
            // 
            this.maskedTextBox10.Location = new System.Drawing.Point(806, 427);
            this.maskedTextBox10.Mask = "00000,000";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox10.TabIndex = 23;
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
            // maskedTextBox11
            // 
            this.maskedTextBox11.Location = new System.Drawing.Point(872, 427);
            this.maskedTextBox11.Mask = "00000,000";
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox11.TabIndex = 25;
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
            // MDIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnConta);
            this.Controls.Add(this.cmbContas);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lstDRE);
            this.Controls.Add(this.lblDezembro);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.lblNovembro);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.lblOutubro);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.lblSetembro);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.lblAgosto);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.lblJulho);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.lblJunho);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.lblMaio);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.lblAbril);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.lblMarco);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lblFevereiro);
            this.Controls.Add(this.txtFevereiro);
            this.Controls.Add(this.lblJaneiro);
            this.Controls.Add(this.txtJaneiro);
            this.Controls.Add(this.lblConta);
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblAbril;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label lblMaio;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label lblJunho;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label lblJulho;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label lblAgosto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.Label lblSetembro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.Label lblOutubro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Label lblNovembro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.Label lblDezembro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11;
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
    }
}

