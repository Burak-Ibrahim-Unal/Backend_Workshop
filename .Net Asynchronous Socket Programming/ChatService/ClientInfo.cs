using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatService
{
    class ClientInfo
    {
        //Socket of the client
        public Socket socket;
        //Name by which the user logged into the chat room
        public string strName;
        //The collection of all clients logged 
        //into the room (an array of type ClientInfo)
        List<ClientInfo> clientList;

        //The main socket on which the server listens to the clients
        Socket serverSocket;

        byte[] byteData = new byte[1024];
    }
}
