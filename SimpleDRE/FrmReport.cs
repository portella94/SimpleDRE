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
    public partial class FrmReport : Form
    {
        private readonly List<Valores> _contasRelatorio;

        public FrmReport()
        {
            InitializeComponent();
        }

        public FrmReport(List<Valores> contasRelatorio)
        {
            InitializeComponent();
            _contasRelatorio = contasRelatorio;
            ConfigurarRelatorio();
        }

        private void ConfigurarRelatorio()
        {
            #region Receita
            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                "RECEITA OPERACIONAL BRUTA",
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Janeiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Fevereiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Marco).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Abril).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Maio).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Junho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Julho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Agosto).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Setembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Outubro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Novembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas).Sum(y => y.Dezembro).ToString("F2"),
            }));

            foreach (var item in _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas))
            {
                lstDRE.Items.Add(new ListViewItem(new string[]
                {
                    item.DescricaoConta,
                        item.Janeiro.ToString("F2"),
                        item.Fevereiro.ToString("F2"),
                        item.Marco.ToString("F2"),
                        item.Abril.ToString("F2"),
                        item.Maio.ToString("F2"),
                        item.Junho.ToString("F2"),
                        item.Julho.ToString("F2"),
                        item.Agosto.ToString("F2"),
                        item.Setembro.ToString("F2"),
                        item.Outubro.ToString("F2"),
                        item.Novembro.ToString("F2"),
                        item.Dezembro.ToString("F2"),
                }));
            }
            #endregion

            lstDRE.Items.Add(new ListViewItem(new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" }));

            #region Deduções Receita
            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                "(-) DEDUÇÕES DA RECEITA BRUTA",
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Janeiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Fevereiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Marco).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Abril).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Maio).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Junho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Julho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Agosto).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Setembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Outubro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Novembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Dezembro).ToString("F2"),
            }));

            foreach (var item in _contasRelatorio.Where(x => x.TipoConta == TipoConta.DeducoesReceita))
            {
                lstDRE.Items.Add(new ListViewItem(new string[]
                {
                    item.DescricaoConta,
                        item.Janeiro.ToString("F2"),
                        item.Fevereiro.ToString("F2"),
                        item.Marco.ToString("F2"),
                        item.Abril.ToString("F2"),
                        item.Maio.ToString("F2"),
                        item.Junho.ToString("F2"),
                        item.Julho.ToString("F2"),
                        item.Agosto.ToString("F2"),
                        item.Setembro.ToString("F2"),
                        item.Outubro.ToString("F2"),
                        item.Novembro.ToString("F2"),
                        item.Dezembro.ToString("F2"),
                }));
            }
            #endregion
            lstDRE.Items.Add(new ListViewItem(new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" }));

            #region RECEITA OPERACIONAL LÍQUIDA
            var p = _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas && x.TipoConta == TipoConta.DeducoesReceita);
            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                "(=) RECEITA OPERACIONAL LÍQUIDA",
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas || x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Janeiro).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Fevereiro).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Marco).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas || x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Abril).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Maio).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Junho).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Julho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas || x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Agosto).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Setembro).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Outubro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Receitas || x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Novembro).ToString("F2"),
                _contasRelatorio.Where(x =>x.TipoConta == TipoConta.Receitas ||  x.TipoConta == TipoConta.DeducoesReceita).Sum(y => y.Dezembro).ToString("F2"),
            }));
            #endregion
            lstDRE.Items.Add(new ListViewItem(new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" }));


            #region Despesa
            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                "DESPESAS",
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Janeiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Fevereiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Marco).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Abril).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Maio).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Junho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Julho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Agosto).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Setembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Outubro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Novembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas).Sum(y => y.Dezembro).ToString("F2"),
            }));
            foreach (var item in _contasRelatorio.Where(x => x.TipoConta == TipoConta.Despesas))
            {
                lstDRE.Items.Add(new ListViewItem(new string[]
                {
                    item.DescricaoConta,
                        item.Janeiro.ToString("F2"),
                        item.Fevereiro.ToString("F2"),
                        item.Marco.ToString("F2"),
                        item.Abril.ToString("F2"),
                        item.Maio.ToString("F2"),
                        item.Junho.ToString("F2"),
                        item.Julho.ToString("F2"),
                        item.Agosto.ToString("F2"),
                        item.Setembro.ToString("F2"),
                        item.Outubro.ToString("F2"),
                        item.Novembro.ToString("F2"),
                        item.Dezembro.ToString("F2"),
                }));
            }
            #endregion
            lstDRE.Items.Add(new ListViewItem(new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" }));

            #region Provisao
            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                "= RESULTADO OPERACIONAL ANTES DO IR E CSLL",
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Janeiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Fevereiro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Marco).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Abril).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Maio).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Junho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Julho).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Agosto).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Setembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Outubro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Novembro).ToString("F2"),
                _contasRelatorio.Where(x => x.TipoConta != TipoConta.Provisao).Sum(y => y.Dezembro).ToString("F2"),
            }));
            var g = _contasRelatorio.FirstOrDefault(x => x.DescricaoConta == "(-) Provisão para IR e CSLL");
            if (g != null)
            {
                lstDRE.Items.Add(new ListViewItem(new string[]
                {
                    "(-) Provisão para IR e CSLL",
                    g.Janeiro.ToString("F2"),
                    g.Fevereiro.ToString("F2"),
                    g.Marco.ToString("F2"),
                    g.Abril.ToString("F2"),
                    g.Maio.ToString("F2"),
                    g.Junho.ToString("F2"),
                    g.Julho.ToString("F2"),
                    g.Agosto.ToString("F2"),
                    g.Setembro.ToString("F2"),
                    g.Outubro.ToString("F2"),
                    g.Novembro.ToString("F2"),
                    g.Dezembro.ToString("F2"),
                }));
            }
            else
            {
                lstDRE.Items.Add(new ListViewItem(new string[]
                {
                    "(-) Provisão para IR e CSLL",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                    "0",
                }));
            }
            #endregion

            lstDRE.Items.Add(new ListViewItem(new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" }));

            lstDRE.Items.Add(new ListViewItem(new string[]
            {
                "(=) RESULTADO LÍQUIDO DO EXERCÍCIO",
                _contasRelatorio.Sum(y => y.Janeiro).ToString("F2"),
                _contasRelatorio.Sum(y => y.Fevereiro).ToString("F2"),
                _contasRelatorio.Sum(y => y.Marco).ToString("F2"),
                _contasRelatorio.Sum(y => y.Abril).ToString("F2"),
                _contasRelatorio.Sum(y => y.Maio).ToString("F2"),
                _contasRelatorio.Sum(y => y.Junho).ToString("F2"),
                _contasRelatorio.Sum(y => y.Julho).ToString("F2"),
                _contasRelatorio.Sum(y => y.Agosto).ToString("F2"),
                _contasRelatorio.Sum(y => y.Setembro).ToString("F2"),
                _contasRelatorio.Sum(y => y.Outubro).ToString("F2"),
                _contasRelatorio.Sum(y => y.Novembro).ToString("F2"),
                _contasRelatorio.Sum(y => y.Dezembro).ToString("F2"),
            }));

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Em construção!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}