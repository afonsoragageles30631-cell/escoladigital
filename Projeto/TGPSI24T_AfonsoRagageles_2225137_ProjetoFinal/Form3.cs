using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGPSI24T_AfonsoRagageles_2225137_ProjetoFinal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string opcao = comboBox1.SelectedItem.ToString();
            if (opcao == "Cartão de Crédito")
            {
                FormCartãodeCrédito C = new FormCartãodeCrédito();
                C.Show();

            }
            else if (opcao == "MBway")
            {
                FormMBway M = new FormMBway();
                M.Show();
            }
            else if (opcao == "Pagamento em Mãos")
            {
                FormPagamento pagamento = new FormPagamento();
                pagamento.Show();
            }
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
