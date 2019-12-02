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
        public MDIFrm()
        {
            InitializeComponent();
            CarregarListaDeContas();
            CarregarCombo();
        }

        private void CarregarListaDeContas()
        {
            var contas = Conta.GetAll();
            _contas = new List<Conta>();
            foreach (var conta in contas)
            {
                _contas.Add(conta);
            }
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (lstDRE.SelectedIndices.Count == 0)
            {
                MessageBox.Show(@"Favor adicionar dados a tabela!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstDRE.SelectedIndices.Count < 1)
            {
                MessageBox.Show(@"Favor selecionar um produto que deseja remover!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConta_Click(object sender, EventArgs e)
        {
            var novaConta = new FrmConta();
            novaConta.ShowDialog();
            CarregarCombo();
        }
    }
}
