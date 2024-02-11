using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotChatGPT
{
    public class DialogoGPT
    {
        public string Message { get; private set; }
        public void SendMessage(string message)
        {
            Message = message;
        }
    }
}
