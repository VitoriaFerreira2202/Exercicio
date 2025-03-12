using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, System.EventArgs e)
        {
            var produto = new Produto("Motorola", 3.9, "Smartphone XYZ 12");
            lblDescricao.Text = produto.ExibirDetalhes();
        }

        private void bntClique_Click(object sender, System.EventArgs e)
        {
            //Button btnCLiquer = new Button();
            //var nome = (txtNome.Text).Trim();
            //var preco = (txtPreco.Text).Trim();
            //var descricao = (txtDescricao.Text).Trim();
            //lblResultado.Text = preco + nome + descricao;
           
            var nome = (txtNome.Text).Trim();
            var preco = Convert.ToDouble(txtPreco.Text.Trim());
            var descricao = (txtDescricao.Text).Trim();
            var produto = new Produto(nome, preco, descricao);
            lblResultado.Text = produto.ExibirDetalhes();
        }
    }
}
