using Application.UseCases.UserManager.AddUser;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.User.AddUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserPresenter _presenter;
        private readonly IAddUserUseCase _useCase;
        public UserController(UserPresenter presenter, IAddUserUseCase useCase)
        {
            _presenter = presenter;
            _useCase = useCase;
        }

        [HttpPost("[action]")]
        public IActionResult CreateUser([FromBody] AddUserRequest request)
        {
            var requestUc = new AddUserUcRequest("pedro", "pedro@gmail.com");
            _useCase.Execute(requestUc);
            return _presenter.Result;
        }
    }
}
