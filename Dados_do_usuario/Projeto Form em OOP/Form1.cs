using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Form_em_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonFinalizar_Click(object sender, EventArgs e)
        {
            Dados_OOP dop = new Dados_OOP();

            dop.nome = textBox1.Text;
            dop.cpf = int.Parse(textBox2.Text);
            dop.endereco = textBox3.Text;

            listBoxMensagem.Items.Add("Seja Bem Vindo!! Seus dados foram salvos.");
            listBoxMensagem.Items.Add("Confira-os Abaixo");
            listBoxMensagem.Items.Add(dop.nome);
            listBoxMensagem.Items.Add(dop.cpf);
            listBoxMensagem.Items.Add(dop.endereco);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
