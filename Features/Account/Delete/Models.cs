namespace Features.Account.Delete
{
    internal sealed class Request
    {
        public string username { get; set; }
        public string password { get; set; }


    }

    internal sealed class Validator : Validator<Request>
    {
        public Validator()
        {

        }
    }

    internal sealed class Response
    {
        public string Message => "This endpoint hasn't been implemented yet!";
    }
}
