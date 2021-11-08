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

        //Converts the bytes into an object of type Data
        public Data(byte[] data)
        {
            //The bytes are for the Commands and Process
            // First 4 bytes
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            //The next 4 bytes store the length of the name
            int nameLen = BitConverter.ToInt32(data, 4);

            //The next 4 store the length of the message
            int msgLen = BitConverter.ToInt32(data, 8);

            //Makes sure that strName has been passed in the array of bytes
            if (nameLen > 0)
                this.strName = Encoding.UTF8.GetString(data, 12, nameLen);
            else
                this.strName = null;

            //This checks message field
            if (msgLen > 0)
                this.strMessage = Encoding.UTF8.GetString(data,
                                  12 + nameLen, msgLen);
            else
                this.strMessage = null;
        }

        //Converts the Data structure into an array of bytes
        public byte[] ToByte()
        {
            List<byte> result = new List<byte>();

            //First 4 bytes are for the Command
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            //Add the length of the name
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Length of the message
            if (strMessage != null)
                result.AddRange(BitConverter.GetBytes(strMessage.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Add the name
            if (strName != null)
                result.AddRange(Encoding.UTF8.GetBytes(strName));

            //And, lastly we add the message text to our array of bytes
            if (strMessage != null)
                result.AddRange(Encoding.UTF8.GetBytes(strMessage));

            return result.ToArray();
        }
    }
}
