using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDRE
{
    public partial class FrmConta : Form
    {
        public FrmConta()
        {
            InitializeComponent();
            PopularTipoConta();
        }
        private void PopularTipoConta()
        {
            try
            {
                cmbTipoConta.DataSource = Enum.GetNames(typeof(TipoConta));
                cmbTipoConta.DisplayMember = "Description";
                cmbTipoConta.DataSource = Enum.GetValues(typeof(TipoConta))
                    .Cast<Enum>()
                    .Select(value => new
                    {
                        (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                        value
                    })
                    .OrderBy(item => item.value)
                    .ToList();
                cmbTipoConta.DisplayMember = "Description";
                cmbTipoConta.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao carregar tipos de conta: \n {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var conta = new Conta();
            //conta.idConta = Conta.GetId();
            conta.DescricaoConta = txtDescricaoConta.Text;
            Enum.TryParse(cmbTipoConta.SelectedValue.ToString(), out TipoConta tipo);
            conta.TipoConta = tipo;
            try
            {
                Conta.Insert(conta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao inserir conta: \n {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Conta inserida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}