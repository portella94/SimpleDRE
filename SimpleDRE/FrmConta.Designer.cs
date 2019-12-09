namespace SimpleDRE
{
    partial class FrmConta
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
            this.lblDescricaoConta = new System.Windows.Forms.Label();
            this.txtDescricaoConta = new System.Windows.Forms.TextBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescricaoConta
            // 
            this.lblDescricaoConta.AutoSize = true;
            this.lblDescricaoConta.Location = new System.Drawing.Point(12, 47);
            this.lblDescricaoConta.Name = "lblDescricaoConta";
            this.lblDescricaoConta.Size = new System.Drawing.Size(86, 13);
            this.lblDescricaoConta.TabIndex = 0;
            this.lblDescricaoConta.Text = "Descrição Conta";
            // 
            // txtDescricaoConta
            // 
            this.txtDescricaoConta.Location = new System.Drawing.Point(15, 63);
            this.txtDescricaoConta.Name = "txtDescricaoConta";
            this.txtDescricaoConta.Size = new System.Drawing.Size(357, 20);
            this.txtDescricaoConta.TabIndex = 1;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Location = new System.Drawing.Point(12, 86);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(74, 13);
            this.lblTipoConta.TabIndex = 2;
            this.lblTipoConta.Text = "Tipo de Conta";
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Location = new System.Drawing.Point(15, 102);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(357, 21);
            this.cmbTipoConta.TabIndex = 3;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(297, 226);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir Conta";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.cmbTipoConta);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.txtDescricaoConta);
            this.Controls.Add(this.lblDescricaoConta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserção de Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricaoConta;
        private System.Windows.Forms.TextBox txtDescricaoConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.Button btnInserir;
    }
}