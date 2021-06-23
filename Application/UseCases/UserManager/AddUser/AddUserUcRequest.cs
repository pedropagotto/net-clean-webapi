namespace Application.UseCases.UserManager.AddUser
{
    public class AddUserUcRequest
    {
        public AddUserUcRequest(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public AddUserUcResponse Response { get; set; }
    }
}
