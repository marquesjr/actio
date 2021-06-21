namespace Actio.Common.Events
{
    public class UserCreated : IEvent
    {
        public string Email { get; }
        public string Name { get; }

        // To avoid serialization issues
        protected UserCreated() {}

        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}