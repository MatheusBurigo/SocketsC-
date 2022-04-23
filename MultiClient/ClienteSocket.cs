using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MultiClient
{
    public static class ClienteSocket
    {
        public static bool ConectarAoServidor(Socket clientSocket, int PORT)
        {
            int attempts = 0;

            while (attempts <= 20)
            {
                attempts++;
                clientSocket.Connect(IPAddress.Loopback, PORT);

                if (clientSocket.Connected)
                    return true;
            }
            return false;
        }

        private static void Deslogar(Socket clientSocket)
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            //Environment.Exit(0);
        }

        private static void EnviarMensagem(string text, Socket clienteSocket)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            clienteSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private static void ReceberResposta(Socket clienteSocket)
        {
            var buffer = new byte[2048];
            int received = clienteSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            Console.WriteLine(text);
        }
    }
}
