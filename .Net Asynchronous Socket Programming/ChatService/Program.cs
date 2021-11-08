using System;
using System.Net;
using System.Net.Sockets;

namespace ChatService
{
    class Program
    {
        static Socket serverSocket;
        static void Main(string[] args)
        {
            try
            {
                //We are using TCP sockets
                Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //Assign the any IP of the machine and listen on port number 1000
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, 1000);

                //Bind and listen on the given address
                serverSocket.Bind(ipEndPoint);
                serverSocket.Listen(4);
                //Accept the incoming clients
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "SGSserverTCP");
            }
        }


        private static void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket clientSocket = serverSocket.EndAccept(ar);

                //Start listening for more clients
                serverSocket.BeginAccept(new AsyncCallback(OnAccept), null);

                //Once the client connects then start 
                //receiving the commands from her
                clientSocket.BeginReceive(byteData, 0,
                    byteData.Length, SocketFlags.None,
                    new AsyncCallback(OnReceive), clientSocket);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "SGSserverTCP");
            }
        }
    }
}
