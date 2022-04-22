using MultiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            ClientSocket.ConnectToServer(clientSocket, 100);
        }
    }
}
