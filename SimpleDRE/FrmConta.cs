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


                //cmbTipoConta.DataSource = from Conta n in Enum.GetValues(typeof(TipoConta))
                //                          select new { Text = n, Value = Convert.ToByte(n) };
                //cmbTipoConta.DisplayMember = "Text";
                //cmbTipoConta.ValueMember = "Value";

                cmbTipoConta.DataSource = Enum.GetNames(typeof(TipoConta));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Erro ao carregar Àreas: \n {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var conta = new Conta();
            //conta.idConta = Conta.GetId();
            conta.DescricaoConta = txtDescricaoConta.Text;
            conta.TipoConta = (TipoConta)Enum.Parse(typeof(TipoConta), cmbTipoConta.Text);
            Conta.Insert(conta);

        }
    }
}
