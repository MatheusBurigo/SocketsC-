using System.Net.Sockets;

namespace MultiClient
{
    public class Cliente
    {
        public string nomeDoCliente;
        public Socket socket;

        public Cliente(string nomeDoCliente, Socket socket)
        {
            this.nomeDoCliente = nomeDoCliente;
            this.socket = socket;
        }

        public override string ToString()
        {
            return nomeDoCliente;
        }
    }
}
