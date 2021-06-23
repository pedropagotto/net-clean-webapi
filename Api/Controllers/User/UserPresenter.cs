using Application.Boundaries;
using Application.UseCases.UserManager.AddUser;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api.Controllers.User
{
    public class UserPresenter : IOutputPort<AddUserUcResponse>
    {
        public IActionResult Result { get; private set; }

        public void Error(string message)
        {
            throw new System.NotImplementedException();
        }

        public void Error(List<string> messages)
        {
            throw new System.NotImplementedException();
        }

        public void Standard(AddUserUcResponse result)
        {
            Result = new OkObjectResult(new AddUserUcResponse(result.UserName, result.Email));
        }
    }
}
