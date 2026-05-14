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
    public partial class Pagamento : Form
    {
        public Pagamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1 == null ||
                textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                Final final = new Final();
                final.Show();
                this.Hide();
            }
        }
    }
}
