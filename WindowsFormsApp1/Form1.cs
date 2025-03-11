using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ExibirDetalhes()
        {
            var produto = new Produto("Motorola", 3.9, "Smartphone XYZ 12");
        }

    }
}
