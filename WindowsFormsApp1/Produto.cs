using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }
        public Produto(string nome, double preco, string descricao)
        {
            Nome = nome;
            Preco = preco;
            Descricao = descricao;
        }
    }
}
