using AddictionCollaboration.Interfaces;

namespace AddictionCollaboration.Factory
{
    public abstract class MessageServiceFactory
    {
        public abstract IMessageService Create(IPerson from, IPerson to);
    }
}
