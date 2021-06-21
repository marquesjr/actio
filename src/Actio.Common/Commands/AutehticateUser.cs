namespace Actio.Common.Commands
{
    public class AutehticateUser: ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}