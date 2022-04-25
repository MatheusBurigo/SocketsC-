
using MultiClient;
using System.Net.Sockets;

namespace Tela
{
    public partial class AdicionarClienteFrm : Form
    {
        public AdicionarClienteFrm()
        {
            InitializeComponent();
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            var nomeDoCliente = txtNomeDoCliente.Text;

            if (String.IsNullOrEmpty(nomeDoCliente))
            {
                MessageBox.Show("Nome Inválido");
            }
            else
            {
                Socket socketDoCliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                ClienteSocket.ConectarAoServidor(socketDoCliente, 100);

                Cliente cliente = new Cliente(nomeDoCliente, socketDoCliente);


                ClienteFrm.clientes.Add(cliente);

                ClienteFrm.clienteAtual = cliente;            

                Close();
            }       
        }
    }
}
