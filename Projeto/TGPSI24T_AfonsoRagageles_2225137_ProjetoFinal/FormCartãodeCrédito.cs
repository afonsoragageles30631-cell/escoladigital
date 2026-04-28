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
    public partial class FormCartãodeCrédito : Form
    {
        public FormCartãodeCrédito()
        {
            InitializeComponent();
        }

        private void FormCartãodeCrédito_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPagamento pagamento = new FormPagamento();
            pagamento.Show();
            this.Hide();
        }
    }
}
