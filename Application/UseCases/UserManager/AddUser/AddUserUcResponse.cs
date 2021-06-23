namespace Application.UseCases.UserManager.AddUser
{
    public class AddUserUcResponse
    {
        public AddUserUcResponse(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }

        public string UserName { get; private set; }
        public string Email { get; private set; }
    }
}
