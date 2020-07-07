using System;
using AddictionCollaboration.Interfaces;

namespace AddictionCollaboration.Service
{
    public class EmailMessageService : IMessageService
    {
        private readonly IPerson _messageFrom;
        private readonly IPerson _messageTo;

        public EmailMessageService(IPerson from, IPerson to)
        {
            _messageFrom = from;
            _messageTo = to;
        }
        
        public void SendMessage(string message)
        {
            Console.WriteLine("Send email from " + _messageFrom.FirstName + " to " + _messageTo.FirstName);
        }
    }
}
