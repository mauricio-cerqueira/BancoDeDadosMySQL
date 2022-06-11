using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BancoDeDados.DBConnect();

        }


        private void button_inserir_Click(object sender, EventArgs e)
        {
            BancoDeDados.Insert_Pessoa(textBox_nome.Text, textBox_sobrenome.Text);
            textBox_nome.Text = "Digite o nome aqui";
            textBox_sobrenome.Text = "Digite o sobrenome aqui";
        }
        private void button_alterar_Click(object sender, EventArgs e)
        {
            BancoDeDados.Update_Sobrenome(textBox_nome.Text, textBox_sobrenome.Text);
            textBox_nome.Text = "Digite o nome aqui";
            textBox_sobrenome.Text = "Digite o sobrenome aqui";
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            BancoDeDados.Delete(textBox_nome.Text, textBox_sobrenome.Text);
            textBox_nome.Text = "Digite o nome aqui";
            textBox_sobrenome.Text = "Digite o sobrenome aqui";
        }
        private void button_contar_Click(object sender, EventArgs e)
        {
            label_contaPessoas.Text = "" + BancoDeDados.Count_Pessoa();
        }
        private void button_listar_Click(object sender, EventArgs e)
        {
            textBox_lista.Clear();
            string[,] list = BancoDeDados.Lista_Pessoas();

            for (int i = 0; i < list.Length/3; i++)
            {
                textBox_lista.AppendText("Nome: " + list[i, 1] + " "+ list[i, 2] + " "+ Environment.NewLine);
            }
        }
    }
}
