using System;
using System.Collections.Generic;
using System.Text;

namespace ChatService
{
    enum Command
    {
        //Log into the server
        Login,
        //Logout of the server
        Logout,
        //Send a text message to all the chat clients     
        Message,
        //Get a list of users in the chat room from the server
        List
    }
}
