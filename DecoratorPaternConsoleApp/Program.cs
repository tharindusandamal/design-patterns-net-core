using System;

namespace DediatorPaternConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message
            {
                CustomMessage = "Welcome by Email"
            };
            EmailMessageCommand emailMessageCommand = new EmailMessageCommand(message);

            Message message2 = new Message
            {
                CustomMessage = "Welcome by SMS"
            };
            SmsMessageCommand smsMessageCommand = new SmsMessageCommand(message2);

            Broker broker = new Broker();
            broker.SendMessage(emailMessageCommand);
            broker.SendMessage(smsMessageCommand);
            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}
