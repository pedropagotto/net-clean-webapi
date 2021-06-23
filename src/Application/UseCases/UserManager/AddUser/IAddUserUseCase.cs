using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.UserManager.AddUser
{
    public interface IAddUserUseCase
    {
        void Execute(AddUserUcRequest request);
    }
}
