namespace Application.UseCases.UserManager.GetUsers
{
    public class GetUsersUcRequest
    {
        public GetUsersUcRequest()
        {
            Response = new GetUsersUcResponse();
        }

        public GetUsersUcResponse Response { get; set; }

    }
}
