using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MultiClient
{
    public static class ClientSocket
    {
        public static void ConnectToServer(Socket clientSocket, int PORT)
        {
            int attempts = 0;

            while (!clientSocket.Connected && attempts != 20)
            {
                try
                {
                    attempts++;
                    clientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException)
                {
                }
            }
        }

        private static void RequestLoop()
        {

            while (true)
            {
                SendRequest();
                ReceiveResponse();
            }
        }

        private static void Exit(Socket clientSocket)
        {
            SendString("exit"); // Tell the server we are exiting
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            Environment.Exit(0);
        }

        private static void SendRequest()
        {
            Console.Write("Send a request: ");
            string request = Console.ReadLine();
            SendString(request);

            if (request.ToLower() == "exit")
            {
                Exit();
            }
        }

        private static void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private static void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = clientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);
            Console.WriteLine(text);
        }
    }
}
