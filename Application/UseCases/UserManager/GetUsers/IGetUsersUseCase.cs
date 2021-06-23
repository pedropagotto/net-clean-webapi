using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases.UserManager.GetUsers
{
    public interface IGetUsersUseCase
    {
        void Execute(GetUsersUcRequest request);
    }
}
