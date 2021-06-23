using System.ComponentModel.DataAnnotations;

namespace Api.Controllers.User.AddUser
{
    public class AddUserRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
