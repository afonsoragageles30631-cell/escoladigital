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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void SalvarTeni_Click(object sender, EventArgs e)
        {
            label2.Text = "90 Euros";
            
            string Nome = textBoxNome.Text;
            string Marca = textBoxMarca.Text;
            string Tamanho = textBoxTamanho.Text;
            string Cor = textBoxCor.Text;

            MessageBox.Show("Você escolheu o modelo " + Nome + " da marca " + Marca + ", tamanho " + Tamanho + " " +  Cor);
        }

        private void Seguinte_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

            Form3 form2 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
