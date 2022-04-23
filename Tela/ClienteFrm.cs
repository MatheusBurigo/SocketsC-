using MultiClient;

namespace Tela
{
    public partial class ClienteFrm : Form
    {

        public static List<Cliente> clientes = new List<Cliente>();
        public List<Cliente> clientesParaEnvio = new List<Cliente>();

        public ClienteFrm()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            clientes.Add(new Cliente("aaa", null));
            clientes.Add(new Cliente("bbb", null));

            ClientesBindingSource.DataSource = clientes;
            lsbConectados.DataSource = ClientesBindingSource;
        }

        private void btnAcionarCliente_Click(object sender, EventArgs e)
        {
            var telaAdiconarCliente = new AdicionarClienteFrm();

            telaAdiconarCliente.ShowDialog();
        }

        private void SelecionarClientes()
        {
            lblClientesParaEnviar.Text = "";

            foreach (var cliente in lsbConectados.SelectedItems)
            {
                lblClientesParaEnviar.Text += (lblClientesParaEnviar.Text == "" ? "" : ",") + cliente.ToString();
                clientesParaEnvio.Add((Cliente)cliente);
            }
        }

        private void lsbConectados_MouseLeave(object sender, EventArgs e)
        {
            SelecionarClientes();

            if (lblClientesParaEnviar.Text == "")
            {
                btnEnviar.Enabled = false;
                btnSair.Enabled = false;
            }
            else
            {
                btnEnviar.Enabled = true;
                btnSair.Enabled = true;
            }

        }
    }
}