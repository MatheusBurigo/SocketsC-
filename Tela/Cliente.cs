namespace Tela
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaAdiconarCliente = new AdicionarCliente();

            telaAdiconarCliente.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Servidor tela = new Servidor();
            tela.ShowDialog();
        }
    }
}