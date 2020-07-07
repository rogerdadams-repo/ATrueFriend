using AddictionCollaboration.Factory;
using AddictionCollaboration.Interfaces;

namespace AddictionCollaboration.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPerson person = PersonFactory.CreatePerson();
            IPerson sponsor = PersonFactory.CreatePerson();

            IMessageService messageService = MessageServiceFactory.CreateMessageService(person, sponsor);
            string message = messageService.SendMessage(person, sponsor);

            System.Console.WriteLine(message);
        }
    }
}
