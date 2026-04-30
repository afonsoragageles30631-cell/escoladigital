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
            MessageBox.Show("O Valor da Sua Compra é 90 Euros.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
       string.IsNullOrWhiteSpace(textBox2.Text) ||
       string.IsNullOrWhiteSpace(textBox3.Text) ||
       string.IsNullOrWhiteSpace(textBox4.Text) ||
       comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preenche todas as caixas de texto e seleciona uma opção!");
            }
            else
            {
                FormPagamento formPagamento = new FormPagamento();
                formPagamento.Show();

                FormModelos form3 = new FormModelos();
                formPagamento.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O seu cartão foi adicionado!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();

        }
    }
}
