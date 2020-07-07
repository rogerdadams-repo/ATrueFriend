using AddictionCollaboration.Interfaces;

namespace AddictionCollaboration.Classes
{
    public class Person : IPerson, IPhoneNumber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
    }

}
