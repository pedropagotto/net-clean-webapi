namespace Application.UseCases.UserManager.AddUser.Handlers
{
    public class VerifyProfileHandler : Handler<AddUserUcRequest>
    {
        public override void ProcessRequest(AddUserUcRequest request)
        {
            Sucessor?.ProcessRequest(request);
        }
    }
}
