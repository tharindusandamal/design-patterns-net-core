﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DediatorPaternConsoleApp
{
    public class EmailMessageCommand : IMessageCommand
    {
        private Message oMessage;

        public EmailMessageCommand(Message oMessage)
        {
            this.oMessage = oMessage;
        }

        public void DoAction()
        {
            oMessage.EmailMessage();
        }
    }

    public class SmsMessageCommand : IMessageCommand
    {
        private Message oMessage;

        public SmsMessageCommand(Message oMessage)
        {
            this.oMessage = oMessage;
        }
        public void DoAction()
        {

            oMessage.SmsMessage();
        }
    }
}
