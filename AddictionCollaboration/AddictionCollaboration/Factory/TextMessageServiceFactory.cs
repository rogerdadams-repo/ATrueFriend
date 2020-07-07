using AddictionCollaboration.Interfaces;
using AddictionCollaboration.Service;

namespace AddictionCollaboration.Factory
{
    public class TextMessageServiceFactory : MessageServiceFactory
    {
        public override IMessageService Create(IPerson from, IPerson to) => new TextMessageService(from, to);
    }
}
