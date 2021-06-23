using Domain.Enums;
using Domain.Validators;

namespace Domain.Entities
{
    public class User : Entity
    {
        public User(string userName, string email, EProfile profile)
        {
            UserName = userName;
            Email = email;
            Profile = profile;
            Validate(this, new UserValidator());
        }

        public string UserName { get; private set; }
        public string Email { get; private set; }
        public EProfile Profile { get; private set; }
    }
}
