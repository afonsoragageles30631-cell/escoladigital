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
    public partial class Criar_Conta : Form
    {
        public Criar_Conta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" ||
       textBox3.Text == "" ||
       textBox2.Text == "" ||
       textBox1.Text == "" ||
       textBox5.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }

        }
    }
}
