using System;
using System.Collections.Generic;
using System.Text;

namespace ChatService
{
    class Data
    {
        public string strName { get; set; } //Name by which the client logs into the room
        public Command cmdCommand { get; set; } //Message text

        public string strMessage { get; set; } //Command type (login, logout, send message ...)

        public Data()
        {
            this.cmdCommand = Command.Null;
            this.strMessage = null;
            this.strName = null;
        }
    }
}
