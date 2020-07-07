using AddictionCollaboration.Classes;
using AddictionCollaboration.Interfaces;

namespace AddictionCollaboration.Factory
{
    public class PersonFactory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
    }
}
