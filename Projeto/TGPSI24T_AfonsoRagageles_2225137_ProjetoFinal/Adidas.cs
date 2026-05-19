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
    public partial class Adidas : Form
    {
        public Adidas()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O preço final é de 90 Euros!");
            Pagamento pagamento = new Pagamento();
            pagamento.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O preço final é de 90 Euros!");
            Pagamento pagamento = new Pagamento();
            pagamento.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O preço final é de 90 Euros!");
            Pagamento pagamento = new Pagamento();
            pagamento.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O preço final é de 90 Euros!");
            Pagamento pagamento = new Pagamento();
            pagamento.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewBalance newBalance = new NewBalance();
            newBalance.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeloPronto modelos = new ModeloPronto();
            modelos.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Asics asics = new Asics();
            asics.Show();
            this.Hide();
        }
    }
}
