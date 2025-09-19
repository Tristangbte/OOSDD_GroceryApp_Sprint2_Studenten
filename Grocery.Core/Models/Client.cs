namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        // Properties
        public string EmailAddress { get; private set; }  // Alleen te setten via constructor
        public string Password { get; private set; }      // Alleen te setten via constructor

        // Constructor
        public Client(int id, string name, string emailAddress, string password)
            : base(id, name)
        {
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
