using AddictionCollaboration.Interfaces;
using AddictionCollaboration.Service;

namespace AddictionCollaboration.Factory
{
    public class EmailMessageFactory : MessageServiceFactory
    {
        public override IMessageService Create(IPerson from, IPerson to) => new EmailMessageService(from, to);
    }
}
