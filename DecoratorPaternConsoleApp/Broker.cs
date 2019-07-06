using System;
using System.Collections.Generic;
using System.Text;

namespace DediatorPaternConsoleApp
{
    public interface IMessageCommand
    {
        void DoAction();
    }

    public class Broker
    {
        public void SendMessage(IMessageCommand command)
        {
            command.DoAction();
        }
    }
}
