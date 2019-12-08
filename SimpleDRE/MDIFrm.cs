using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDRE
{
    public partial class MDIFrm : Form
    {
        private List<Conta> _contas = null;
        private List<Valores> _contasRelatorio = new List<Valores>();
        public MDIFrm()
        {
            InitializeComponent();
            CarregarListaDeContas();
            CarregarCombo();
        }
        #region Metodos Criados
        private void CarregarListaDeContas()
        {
            var contas = Conta.GetAll();
            _contas = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.TipoConta == TipoConta.Despesas
                    || conta.TipoConta == TipoConta.Receitas
                    || conta.TipoConta == TipoConta.DeducoesReceita)
                    _contas.Add(conta);
            }
            _contas.Add(new Conta
            {
                DescricaoConta = "(-) Provisão para IR e CSLL",
                TipoConta = TipoConta.Provisao
            });
        }

        private void CarregarCombo()
        {
            try
            {
                cmbContas.DataSource = _contas;
                cmbContas.DisplayMember = "DescricaoConta";
                cmbContas.ValueMember = "idConta";
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao carregar Contas: \n {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CompletarZeros(object sender, EventArgs e)
        {
            var txt = (MaskedTextBox)sender;
            var novoTexto = "";
            foreach (var caractere in txt.Text)
            {
                if (char.IsWhiteSpace(caractere))
                    novoTexto += "0";
                else novoTexto += caractere;
            }
            txt.Text = novoTexto;
            while (!txt.MaskCompleted)
                txt.Text += "0";
        }
        #endregion

        #region Eventos Componentes

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtJaneiro.Text = string.Empty;
            txtFevereiro.Text = string.Empty;
            txtMarco.Text = string.Empty;
            txtAbril.Text = string.Empty;
            txtMaio.Text = string.Empty;
            txtJunho.Text = string.Empty;
            txtJulho.Text = string.Empty;
            txtAgosto.Text = string.Empty;
            txtSetembro.Text = string.Empty;
            txtOutubro.Text = string.Empty;
            txtNovembro.Text = string.Empty;
            txtDezembro.Text = string.Empty;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (lstDRE.Items.Count == 0)
            {
                MessageBox.Show(@"Favor adicionar dados a tabela!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var report = new FrmReport(_contasRelatorio);
            report.ShowDialog();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstDRE.SelectedIndices.Count < 1)
            {
                MessageBox.Show(@"Favor selecionar uma conta que deseja remover!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            lstDRE.Items.RemoveAt(lstDRE.SelectedIndices[0]);
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            var novaConta = new FrmConta();
            novaConta.ShowDialog();
            CarregarCombo();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var c = (Conta)cmbContas.SelectedItem;
            foreach (ListViewItem item in lstDRE.Items)
            {
                if (item.SubItems[0].Text.Equals(c.DescricaoConta))
                {
                    MessageBox.Show(@"Conta já adicionada na lista", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is MaskedTextBox)
                {
                    if (((MaskedTextBox)x).Text.Trim().Equals(","))
                        CompletarZeros(x, new EventArgs());
                }
            }
            var v = new Valores
            {
                idConta = c.idConta,
                DescricaoConta = c.DescricaoConta,
                TipoConta = c.TipoConta
            };
            if (v.TipoConta == TipoConta.DeducoesReceita
                || v.TipoConta == TipoConta.Despesas
                || v.TipoConta == TipoConta.Provisao)
                _contasRelatorio.Add(new Valores
                {
                    idConta = c.idConta,
                    DescricaoConta = c.DescricaoConta,
                    TipoConta = c.TipoConta,
                    Janeiro = Convert.ToDecimal("-" + txtJaneiro.Text),
                    Fevereiro = Convert.ToDecimal("-" + txtFevereiro.Text),
                    Marco = Convert.ToDecimal("-" + txtMarco.Text),
                    Abril = Convert.ToDecimal("-" + txtAbril.Text),
                    Maio = Convert.ToDecimal("-" + txtMaio.Text),
                    Junho = Convert.ToDecimal("-" + txtJunho.Text),
                    Julho = Convert.ToDecimal("-" + txtJulho.Text),
                    Agosto = Convert.ToDecimal("-" + txtAgosto.Text),
                    Setembro = Convert.ToDecimal("-" + txtSetembro.Text),
                    Outubro = Convert.ToDecimal("-" + txtOutubro.Text),
                    Novembro = Convert.ToDecimal("-" + txtNovembro.Text),
                    Dezembro = Convert.ToDecimal("-" + txtDezembro.Text)
                });
            else
                _contasRelatorio.Add(new Valores
                {
                    idConta = c.idConta,
                    DescricaoConta = c.DescricaoConta,
                    TipoConta = c.TipoConta,
                    Janeiro = Convert.ToDecimal(txtJaneiro.Text),
                    Fevereiro = Convert.ToDecimal(txtFevereiro.Text),
                    Marco = Convert.ToDecimal(txtMarco.Text),
                    Abril = Convert.ToDecimal(txtAbril.Text),
                    Maio = Convert.ToDecimal(txtMaio.Text),
                    Junho = Convert.ToDecimal(txtJunho.Text),
                    Julho = Convert.ToDecimal(txtJulho.Text),
                    Agosto = Convert.ToDecimal(txtAgosto.Text),
                    Setembro = Convert.ToDecimal(txtSetembro.Text),
                    Outubro = Convert.ToDecimal(txtOutubro.Text),
                    Novembro = Convert.ToDecimal(txtNovembro.Text),
                    Dezembro = Convert.ToDecimal(txtDezembro.Text)
                });

            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                c.DescricaoConta,
                txtJaneiro.Text,
                txtFevereiro.Text,
                txtMarco.Text,
                txtAbril.Text,
                txtMaio.Text,
                txtJunho.Text,
                txtJulho.Text,
                txtAgosto.Text,
                txtSetembro.Text,
                txtOutubro.Text,
                txtNovembro.Text,
                txtDezembro.Text,
            }));
        }

        #region Validating
        private void txtJaneiro_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtFevereiro_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtMarco_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtAbril_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtMaio_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtJunho_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtJulho_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtAgosto_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtSetembro_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtOutubro_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtNovembro_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }

        private void txtDezembro_Validating(object sender, CancelEventArgs e)
        {
            CompletarZeros(sender, e);
        }
        #endregion

        #endregion


    }
}
