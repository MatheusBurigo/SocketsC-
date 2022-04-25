using MultiClient;

namespace Tela
{
    public partial class ClienteFrm : Form
    {

        public static List<Cliente> clientesConectados = new List<Cliente>();
        public static List<Cliente> clientes= new List<Cliente>();
        public static Cliente? clienteAtual = null;
        public List<Cliente> clientesParaEnvio = new List<Cliente>();

        public ClienteFrm()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
        }

        private void AtualizarDados()
        {
            clientesConectados.AddRange(clientes);

            clientesConectados.Remove(clienteAtual);

            ClientesBindingSource.DataSource = clientesConectados;
            lsbConectados.DataSource = ClientesBindingSource;
           
        }

        private void btnAcionarCliente_Click(object sender, EventArgs e)
        {
            var telaAdiconarCliente = new AdicionarClienteFrm();
            telaAdiconarCliente.ShowDialog();
        }

        private void SelecionarClientesParaEnvio()
        {
            lblClientesParaEnviar.Text = "";

            foreach (var cliente in lsbConectados.SelectedItems)
            {
                if (cliente == clienteAtual)
                {
                    continue;
                }

                lblClientesParaEnviar.Text += (lblClientesParaEnviar.Text == "" ? "" : ",") + cliente.ToString();

                clientesParaEnvio.Add((Cliente)cliente);
            }
        }

        private void lsbConectados_MouseEnter(object sender, EventArgs e)
        {
            AtualizarDados();

            SelecionarClientesParaEnvio();

            if (clienteAtual != null)
            {
                lblMensagemEnviadaPor.Text = clienteAtual.nomeDoCliente;
            }
            else
            {
                lblMensagemEnviadaPor.Text = "";
            }

            if (lblClientesParaEnviar.Text != "" && lblMensagemEnviadaPor.Text != "")
            {
                btnEnviar.Enabled = true;
            }
            else
            {
                btnEnviar.Enabled = false;
            }

      
        }
    }
}